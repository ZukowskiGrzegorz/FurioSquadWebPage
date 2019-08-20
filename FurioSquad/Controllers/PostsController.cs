using FurioSquad.Data;
using FurioSquad.Models;
using FurioSquad.Models.BlogViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurioSquad.Controllers
{
    public class PostsController : Controller
    {
        private readonly FurioContext _context;

        public PostsController(FurioContext context)
        {
            _context = context;
        }

        // GET: Posts
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;//provides the view with the current sort order, because this must be included in the paging links in order to keep the sort order the same while paging
            ViewData["NameSortParam"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParam"] = sortOrder == "Date" ? "date_desc" : "Date";
            if(searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString; //provides the view with the current filter string.This value must be included in the paging links in order to maintain the filter settings during paging, and it must be restored to the text box when the page is redisplayed

            int pageSize = 3;

            var furioContext = _context.Posts.Include(p => p.User).OrderByDescending(p=>p.PostDate);

            ViewBag.XXX = Queries();

            return View(await PaginatedList<Post>.CreateAsync(furioContext.AsNoTracking(), pageNumber?? 1, pageSize));
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            var post = new Post();
            post.PostTags = new List<PostTag>();
            PopulatePostsWithTags(post);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Nick");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Content,UserId")] Post post)
        {
            //TODO dodać wyświetlanie tagów
            if (ModelState.IsValid)
            {
                post.ShortDescription = post.Content.Substring(0, 300);

                post.PostDate = DateTime.Today;
                post.EditedDate = DateTime.Today;
                post.LikeCount = 0;


                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Nick", post.UserId);
            //TODO: Modify this method like Edit method
            PopulatePostsWithTags(post);
            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Nick", post.UserId);
            post.PostTags = new List<PostTag>();
            PopulatePostsWithTags(post);
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("PostId,Title,Content,UserId")] Post post, string[] selectedTags)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postToUpdate = await _context.Posts
                .Include(p => p.PostTags).ThenInclude(t => t.Tag).FirstOrDefaultAsync(m => m.PostId == id);

            if (await TryUpdateModelAsync<Post>(
                    postToUpdate, "",
                    p => p.Title, p => p.Content, p => p.UserId))
            {
                UpdatePostTags(selectedTags, postToUpdate);
                try
                {
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Nie można wykonać zapisau do bazy danych");
                }
                return RedirectToAction(nameof(Index));
            }
            UpdatePostTags(selectedTags, postToUpdate);

            #region comment
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        post.ShortDescription = post.Content.Substring(0, 300);
            //        post.PostDate = post.PostDate;
            //        post.EditedDate = DateTime.Today;
            //        post.LikeCount = post.LikeCount;


            //        _context.Update(post);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!PostExists(post.PostId))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            #endregion
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Nick", post.UserId);
            PopulatePostsWithTags(postToUpdate);
            return View(postToUpdate);
        }
        private void UpdatePostTags(string[] selectedTags, Post postToUpdate)
        {
            if (selectedTags == null)
            {
                postToUpdate.PostTags = new List<PostTag>();
                return;
            }
            var selectedTagsHS = new HashSet<string>(selectedTags);
            var postTags = new HashSet<int>
                (postToUpdate.PostTags.Select(c => c.Tag.TagId));
            foreach (var tag in _context.Tags)
            {
                if (selectedTagsHS.Contains(tag.TagId.ToString()))
                    if (!postTags.Contains(tag.TagId))
                        postToUpdate.PostTags.Add(new PostTag { PostId = postToUpdate.PostId, TagId = tag.TagId });
                    else
                    {
                        if (postTags.Contains(tag.TagId))
                        {
                            PostTag tagToRemove = postToUpdate.PostTags.FirstOrDefault(t => t.TagId == tag.TagId);
                            _context.Remove(tagToRemove);
                        }
                    }
            }
        }
        private void PopulatePostsWithTags(Post post)
        {
            var allTags = _context.Tags;//wybiera wszystkie tagi
            var postsTags = new HashSet<int>(post.PostTags.Select(t => t.TagId));//tworzy kolekcje tagów przypisanych do postów
            var viewModel = new List<AssignedTagsData>();//tworzy listę przypisanych tagów do postu
            foreach (var tag in allTags)
            //dodaje tagi do modelu 
            {
                viewModel.Add(new AssignedTagsData
                {
                    TagId = tag.TagId,
                    Title = tag.Name,
                    Assigned = postsTags.Contains(tag.TagId)

                });
            }
            ViewData["Tags"] = viewModel;//zwraca viewModel poprzez ViewData
        }


        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            //TODO: modify this mathod- something is wrong with cascade delete
            //https://blogs.msdn.microsoft.com/alexj/2009/08/18/tip-33-how-cascade-delete-really-works-in-ef/
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }
        public IQueryable Queries()
        {
            var tagContext = from posts in _context.Posts
                             join postAndTags in _context.PostTags on posts.PostId equals postAndTags.PostId
                             join tags in _context.Tags on postAndTags.TagId equals tags.TagId
                             select new ShowTags { Name = tags.Name };
            

            return tagContext;
            
        }
    }
}
