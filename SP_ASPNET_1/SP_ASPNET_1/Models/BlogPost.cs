using SP_ASPNET_1.DbFiles.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SP_ASPNET_1.Models
{
    public class BlogPost
    {
        public int BlogPostID { get; set; }
        public string Title { get; set; }
        [ForeignKey("User")]
        public string FK_UserId { get; set; }
        public User User { get; set; }

        
        public DateTime DateTime { get; set; }
        [required]
        [MinLength(50)]
        public string Content { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Like> Likes { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}