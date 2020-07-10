using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SP_ASPNET_1.DbFiles.Contexts;
using SP_ASPNET_1.Models;

namespace SP_ASPNET_1.ViewModels
{
    public class BlogSinglePostViewModel : IBlogViewModel
    {
        public User User { get; set; }
        public BlogPost BlogPost { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}