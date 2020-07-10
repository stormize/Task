using SP_ASPNET_1.DbFiles.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SP_ASPNET_1.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
       
        [ForeignKey("User")]
        public string FK_UserId { get; set; }
        public User User { get; set; }
       
        [ForeignKey("BlogPost")]
        public int FK_BlogPostID { get; set; }
        public BlogPost BlogPost { get; set; }
        [required]
       
        public string Content { get; set; }


    }
}