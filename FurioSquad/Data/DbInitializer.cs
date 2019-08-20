using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurioSquad.Models;

namespace FurioSquad.Data
{
    public class DbInitializer
    {
        public static void Initializer(FurioContext context)
        {
            context.Database.EnsureCreated();

            //Look for any posts
            if (context.Posts.Any())
            {
                return;// DB has been seeded
            }

            var users = new User[]
           {
                new User{Nick="Orlando", Password="qwerty1234", ConfirmPassword="qwerty1234", Email="orlando@asg.pl", RegistredDate=DateTime.Now, Role="Admin" },
                new User{Nick="Bloom", Password="1234qwerty", ConfirmPassword="1234qwerty", Email="bloom@asg.pl", RegistredDate=DateTime.Now, Role="User" }
           };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var posts = new Post[]
            {
                new Post{ Title="Misja Afganistan 2019", ShortDescription="Lorem ipsum dolor sit amet, consectetur adipis",
                Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ac pellentesque enim. Nulla eget mollis"
                +" ex. Nam dictum consequat purus, eu dapibus dolor vehicula euismod. In vestibulum tincidunt aliquam. Pellentesque"+
                " dolor felis, porta ac est sed, placerat fermentum sem. Etiam auctor augue sit amet elit gravida varius. Aenean " +
                "a nisi imperdiet, dapibus massa non, semper arcu. Ut euismod vitae lacus et sollicitudin. Suspendisse potenti. " +
                "Quisque a magna finibus, blandit ante vel, auctor turpis. In eget elit scelerisque, dapibus mi in, viverra arcu. " +
                "Morbi semper mi urna, sit amet mattis mi pharetra malesuada. Sed venenatis ante sed consectetur vehicula. Morbi " +
                "auctor dapibus ex nec feugiat.Cras ullamcorper lorem et odio porta molestie ut vel ante. Sed molestie pulvinar " +
                "neque quis molestie. Nulla eu ipsum at magna dapibus fermentum a sit amet arcu. Nam finibus velit a posuere " +
                "dapibus. Proin facilisis nunc vel tincidunt dapibus. Mauris molestie tristique aliquam. Sed nec purus odio. " +
                "Morbi venenatis semper justo, rhoncus ultrices mauris posuere ut. Nulla tincidunt urna id bibendum facilisis. " +
                "Suspendisse ex lacus, vulputate et ultricies et, tincidunt id ipsum.Fusce mollis quam vitae justo bibendum, ac" +
                " imperdiet lorem dignissim. Sed et diam non orci porta vulputate laoreet sed felis. Ut consequat nisl augue, " +
                "id sollicitudin libero luctus non. Sed sit amet volutpat libero, quis condimentum lorem. Nunc eros neque, " +
                "viverra id ex id, vulputate pellentesque eros. Class aptent taciti sociosqu ad litora torquent per conubia " +
                "nostra, per inceptos himenaeos. Suspendisse laoreet consectetur justo non rhoncus.Cras aliquet non est id" +
                " scelerisque. Nam id aliquet velit. Suspendisse volutpat vitae erat ac ultricies. Nunc lacinia a nisl nec " +
                "dictum. Mauris aliquam ut ex a sollicitudin. Donec efficitur ante in enim vestibulum, quis laoreet odio " +
                "commodo. Vestibulum sem dolor, malesuada vitae sem ac, fermentum blandit urna. Curabitur maximus at lorem" +
                " ut posuere. Integer hendrerit diam at tortor gravida fermentum.", PostDate = DateTime.Now, EditedDate=DateTime.Today,
                LikeCount=10, UserId=users.Single(u=>u.UserId==1).UserId},
                new Post{ Title="Misja Afganistan 2018", ShortDescription="Lorem ipsum dolor sit amet, consectetur adipis",
                Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ac pellentesque enim. Nulla eget mollis"
                +" ex. Nam dictum consequat purus, eu dapibus dolor vehicula euismod. In vestibulum tincidunt aliquam. Pellentesque"+
                " dolor felis, porta ac est sed, placerat fermentum sem. Etiam auctor augue sit amet elit gravida varius. Aenean " +
                "a nisi imperdiet, dapibus massa non, semper arcu. Ut euismod vitae lacus et sollicitudin. Suspendisse potenti. " +
                "Quisque a magna finibus, blandit ante vel, auctor turpis. In eget elit scelerisque, dapibus mi in, viverra arcu. " +
                "Morbi semper mi urna, sit amet mattis mi pharetra malesuada. Sed venenatis ante sed consectetur vehicula. Morbi " +
                "auctor dapibus ex nec feugiat.Cras ullamcorper lorem et odio porta molestie ut vel ante. Sed molestie pulvinar " +
                "neque quis molestie. Nulla eu ipsum at magna dapibus fermentum a sit amet arcu. Nam finibus velit a posuere " +
                "dapibus. Proin facilisis nunc vel tincidunt dapibus. Mauris molestie tristique aliquam. Sed nec purus odio. " +
                "Morbi venenatis semper justo, rhoncus ultrices mauris posuere ut. Nulla tincidunt urna id bibendum facilisis. " +
                "Suspendisse ex lacus, vulputate et ultricies et, tincidunt id ipsum.Fusce mollis quam vitae justo bibendum, ac" +
                " imperdiet lorem dignissim. Sed et diam non orci porta vulputate laoreet sed felis. Ut consequat nisl augue, " +
                "id sollicitudin libero luctus non. Sed sit amet volutpat libero, quis condimentum lorem. Nunc eros neque, " +
                "viverra id ex id, vulputate pellentesque eros. Class aptent taciti sociosqu ad litora torquent per conubia " +
                "nostra, per inceptos himenaeos. Suspendisse laoreet consectetur justo non rhoncus.Cras aliquet non est id" +
                " scelerisque. Nam id aliquet velit. Suspendisse volutpat vitae erat ac ultricies. Nunc lacinia a nisl nec " +
                "dictum. Mauris aliquam ut ex a sollicitudin. Donec efficitur ante in enim vestibulum, quis laoreet odio " +
                "commodo. Vestibulum sem dolor, malesuada vitae sem ac, fermentum blandit urna. Curabitur maximus at lorem" +
                " ut posuere. Integer hendrerit diam at tortor gravida fermentum.", PostDate = DateTime.Now, EditedDate=DateTime.Today,
                LikeCount=7,UserId=users.Single(u=>u.UserId==1).UserId},
                new Post{ Title="Misja Afganistan 2017", ShortDescription="Lorem ipsum dolor sit amet, consectetur adipis",
                Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ac pellentesque enim. Nulla eget mollis"
                +" ex. Nam dictum consequat purus, eu dapibus dolor vehicula euismod. In vestibulum tincidunt aliquam. Pellentesque"+
                " dolor felis, porta ac est sed, placerat fermentum sem. Etiam auctor augue sit amet elit gravida varius. Aenean " +
                "a nisi imperdiet, dapibus massa non, semper arcu. Ut euismod vitae lacus et sollicitudin. Suspendisse potenti. " +
                "Quisque a magna finibus, blandit ante vel, auctor turpis. In eget elit scelerisque, dapibus mi in, viverra arcu. " +
                "Morbi semper mi urna, sit amet mattis mi pharetra malesuada. Sed venenatis ante sed consectetur vehicula. Morbi " +
                "auctor dapibus ex nec feugiat.Cras ullamcorper lorem et odio porta molestie ut vel ante. Sed molestie pulvinar " +
                "neque quis molestie. Nulla eu ipsum at magna dapibus fermentum a sit amet arcu. Nam finibus velit a posuere " +
                "dapibus. Proin facilisis nunc vel tincidunt dapibus. Mauris molestie tristique aliquam. Sed nec purus odio. " +
                "Morbi venenatis semper justo, rhoncus ultrices mauris posuere ut. Nulla tincidunt urna id bibendum facilisis. " +
                "Suspendisse ex lacus, vulputate et ultricies et, tincidunt id ipsum.Fusce mollis quam vitae justo bibendum, ac" +
                " imperdiet lorem dignissim. Sed et diam non orci porta vulputate laoreet sed felis. Ut consequat nisl augue, " +
                "id sollicitudin libero luctus non. Sed sit amet volutpat libero, quis condimentum lorem. Nunc eros neque, " +
                "viverra id ex id, vulputate pellentesque eros. Class aptent taciti sociosqu ad litora torquent per conubia " +
                "nostra, per inceptos himenaeos. Suspendisse laoreet consectetur justo non rhoncus.Cras aliquet non est id" +
                " scelerisque. Nam id aliquet velit. Suspendisse volutpat vitae erat ac ultricies. Nunc lacinia a nisl nec " +
                "dictum. Mauris aliquam ut ex a sollicitudin. Donec efficitur ante in enim vestibulum, quis laoreet odio " +
                "commodo. Vestibulum sem dolor, malesuada vitae sem ac, fermentum blandit urna. Curabitur maximus at lorem" +
                " ut posuere. Integer hendrerit diam at tortor gravida fermentum.", PostDate = DateTime.Now, EditedDate=DateTime.Today,
                LikeCount=8,UserId=users.Single(u=>u.UserId==1).UserId},
                new Post{ Title="Misja Afganistan 2016", ShortDescription="Lorem ipsum dolor sit amet, consectetur adipis",
                Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ac pellentesque enim. Nulla eget mollis"
                +" ex. Nam dictum consequat purus, eu dapibus dolor vehicula euismod. In vestibulum tincidunt aliquam. Pellentesque"+
                " dolor felis, porta ac est sed, placerat fermentum sem. Etiam auctor augue sit amet elit gravida varius. Aenean " +
                "a nisi imperdiet, dapibus massa non, semper arcu. Ut euismod vitae lacus et sollicitudin. Suspendisse potenti. " +
                "Quisque a magna finibus, blandit ante vel, auctor turpis. In eget elit scelerisque, dapibus mi in, viverra arcu. " +
                "Morbi semper mi urna, sit amet mattis mi pharetra malesuada. Sed venenatis ante sed consectetur vehicula. Morbi " +
                "auctor dapibus ex nec feugiat.Cras ullamcorper lorem et odio porta molestie ut vel ante. Sed molestie pulvinar " +
                "neque quis molestie. Nulla eu ipsum at magna dapibus fermentum a sit amet arcu. Nam finibus velit a posuere " +
                "dapibus. Proin facilisis nunc vel tincidunt dapibus. Mauris molestie tristique aliquam. Sed nec purus odio. " +
                "Morbi venenatis semper justo, rhoncus ultrices mauris posuere ut. Nulla tincidunt urna id bibendum facilisis. " +
                "Suspendisse ex lacus, vulputate et ultricies et, tincidunt id ipsum.Fusce mollis quam vitae justo bibendum, ac" +
                " imperdiet lorem dignissim. Sed et diam non orci porta vulputate laoreet sed felis. Ut consequat nisl augue, " +
                "id sollicitudin libero luctus non. Sed sit amet volutpat libero, quis condimentum lorem. Nunc eros neque, " +
                "viverra id ex id, vulputate pellentesque eros. Class aptent taciti sociosqu ad litora torquent per conubia " +
                "nostra, per inceptos himenaeos. Suspendisse laoreet consectetur justo non rhoncus.Cras aliquet non est id" +
                " scelerisque. Nam id aliquet velit. Suspendisse volutpat vitae erat ac ultricies. Nunc lacinia a nisl nec " +
                "dictum. Mauris aliquam ut ex a sollicitudin. Donec efficitur ante in enim vestibulum, quis laoreet odio " +
                "commodo. Vestibulum sem dolor, malesuada vitae sem ac, fermentum blandit urna. Curabitur maximus at lorem" +
                " ut posuere. Integer hendrerit diam at tortor gravida fermentum.", PostDate = DateTime.Now, EditedDate=DateTime.Today,
                LikeCount=2,UserId=users.Single(u=>u.UserId==1).UserId}
            };
            foreach (Post p in posts)
            {
                context.Posts.Add(p);
            }
            context.SaveChanges();

           

            var comments = new Comment[]
            {
                new Comment{Author="BlackJack", Email="blackjack@wp.pl", Content="onec efficitur ante in enim vestib", PostDate=DateTime.Now, LikeCount=2,
                PostId=posts.Single(p=>p.PostId==1).PostId},
                new Comment{Author="JackBlack", Email="blackjack@wp.pl", Content="onec efficitur ante in enim vestib", PostDate=DateTime.Now, LikeCount=-2,
                PostId=posts.Single(p=>p.PostId==2).PostId},
                new Comment{Author="LackBjack", Email="lackbjack@wp.pl", Content="onec efficitur ante in enim vestib", PostDate=DateTime.Now, LikeCount=12,
                PostId=posts.Single(p=>p.PostId==3).PostId}
            };
            foreach (Comment c in comments)
            {
                context.Comments.Add(c);
            }
            context.SaveChanges();

            var replies = new Replie[]
            {
                new Replie{Author="XXxxX", Email="zxcv@xxx.xx", Content="LackBjackasdfasdgqawef  ASDFQASD QWERGF asdf", PostDate=DateTime.Today, LikeCount=0,
                CommentId= comments.Single(c=>c.CommentId==2).CommentId}
            };
            foreach (Replie r in replies)
            {
                context.Add(r);
            }
            context.SaveChanges();

            var tags = new Tag[]
            {
                new Tag{Name="misja", Count=4},
                new Tag{Name="afganistan", Count=4},
                new Tag{Name="asg", Count=2},
                new Tag{Name="talibowie", Count=3},
                new Tag{Name="camp", Count=5},
                new Tag{Name="impreza", Count= 4}
            };
            foreach (Tag t in tags)
            {
                context.Add(t);
            }
            context.SaveChanges();

            var postsLikes = new PostLike[]
            {
                new PostLike{Like=4, Dislike=2,PostId=posts.Single(p=>p.PostId==1).PostId},
                new PostLike{Like=2, Dislike=5,PostId=posts.Single(p=>p.PostId==2).PostId},
                new PostLike{Like=3, Dislike=1,PostId=posts.Single(p=>p.PostId==3).PostId},
                new PostLike{Like=2, Dislike=7,PostId=posts.Single(p=>p.PostId==4).PostId}
            };
            foreach(PostLike pl in postsLikes)
            {
                context.Add(pl);
            }
            context.SaveChanges();

            var commentsLikes = new CommentLike[]
            {
                new CommentLike{Like=2, Dislike=3, CommentId=comments.Single(c=>c.CommentId==1).CommentId},
                new CommentLike{Like=3, Dislike=2, CommentId=comments.Single(c=>c.CommentId==2).CommentId},
                new CommentLike{Like=10, Dislike=1, CommentId=comments.Single(c=>c.CommentId==3).CommentId}
            };
            foreach(CommentLike cl in commentsLikes)
            {
                context.Add(cl);
            }
            context.SaveChanges();

            var repliesLikes = new ReplieLike[]
            {
                new ReplieLike{Like=4, Dislike=0, ReplieId=replies.Single(r=>r.ReplieId==1).ReplieId}
            };
            foreach(ReplieLike rl in repliesLikes)
            {
                context.Add(rl);
            }
            context.SaveChanges();
        }
    }
}
