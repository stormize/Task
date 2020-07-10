using SP_ASPNET_1.DbFiles.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SP_ASPNET_1.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        
       
        [ForeignKey("User")]
        [Index(IsUnique =true)]
        public string FK_UserId { get; set; }
        public User User { get; set; }
        [Index(IsUnique = true)]
        [ForeignKey("BlogPost")]
        public int FK_BlogPostID { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}