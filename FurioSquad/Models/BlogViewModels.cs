using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurioSquad.Models
{

    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Nick musi zawierać od 3 do 15 znaków", MinimumLength = 3)]
        [Display(Name = "Twój Nick")]
        public string Nick { get; set; }
        [Required]
        [StringLength(32, ErrorMessage = "Hasło musi zawierać minimum 6 znaków", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        [Required]
        [StringLength(32, ErrorMessage = "Hasło musi zawierać minimum 6 znaków", MinimumLength = 6)]
        [Compare("Password", ErrorMessage = "Hasła muszą być identyczne")]
        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Podaj email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime RegistredDate { get; set; }
        [Required]
        public string Role { get; set; }

        public virtual List<Post> Posts { get; set; }
        //public virtual List<Comment> Comments { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Tytuł musi zawierać minimum 6 znaków", MinimumLength = 6)]
        [Display(Name = "Tytuł posta")]
        public string Title { get; set; }
        //[Required]
        [StringLength(300, ErrorMessage = "Krótki opis musi zawierać minimum 50 znaków", MinimumLength = 6)]
        [Display(Name = "Krótki opis")]
        public string ShortDescription { get; set; }
        [Required]
        [StringLength(10000, ErrorMessage = "Post musi zawierac od 50 do 10000 znaków", MinimumLength = 50)]
        [Display(Name = "Treść posta")]
        public string Content { get; set; }
        //[Required]
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EditedDate { get; set; }
        public int LikeCount { get; set; }

        //ForeignKey
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<PostTag> PostTags { get; set; }
        public virtual List<Replie> Replies { get; set; }
        public virtual List<PostLike> PostLikes { get; set; }

    }

    public class Comment
    {
        public int CommentId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Minimum 5 znaków", MinimumLength = 5)]
        [Display(Name = "Nick")]
        public string Author { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Podaj email")]
        public string Email { get; set; }
        [Required]
        [StringLength(400, ErrorMessage = "Minimum {2} znaków", MinimumLength = 10)]
        [Display(Name = "Treść komentarza")]
        public string Content { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PostDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EditedDate { get; set; }
        public int LikeCount { get; set; }

        public int PostId { get; set; }
        //public int UserId { get; set; }

        public virtual Post Post { get; set; }
        //public virtual User User { get; set; }

        //public virtual List<Replie> Replies { get; set; }
        public virtual List<CommentLike> CommentLikes { get; set; }

    }
    public class Replie
    {
        public int ReplieId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Minimum 5 znaków", MinimumLength = 5)]
        [Display(Name = "Nick")]
        public string Author { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Podaj email")]
        public string Email { get; set; }
        [Required]
        [StringLength(400, ErrorMessage = "Minimum {2} znaków", MinimumLength = 10)]
        [Display(Name = "Treść komentarza")]
        public string Content { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PostDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EditedDate { get; set; }
        public int LikeCount { get; set; }

        //public int PostId { get; set; }
        public int CommentId { get; set; }

        public Post Post { get; set; }
        //public Comment Comment { get; set; }

        public virtual List<ReplieLike> ReplieLikes { get; set; }
    }
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public List<PostTag> PostTags { get; set; }
    }

    //Junction table for Post and Tag tables
    public class PostTag
    {
        public int PostTagId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }


    public class PostLike
    {
        public int PostLikeId { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }

    public class CommentLike
    {
        public int CommentLikeId { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public int CommentId { get; set; }

        public Comment Comment { get; set; }
    }
    public class ReplieLike
    {
        public int ReplieLikeId { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public int ReplieId { get; set; }

        public Replie Replie { get; set; }
    }

    public class BlogViewModel
    {
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }
        public IList<Tag> Tag { get; set; }
        public int PostDislikes { get; set; }
        public int PostLikes { get; set; }
        public int TotalPosts { get; set; }
       // public List<String> Category { get; set; }
        public Post Post { get; set; }
        public string ID { get; set; }
        public string ShortDescription { get; set; }
        public string Title { get; set; }
        public IList<Tag> PostTags { get; set; }

    }
}
