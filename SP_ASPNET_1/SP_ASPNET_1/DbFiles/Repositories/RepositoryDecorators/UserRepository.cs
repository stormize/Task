using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SP_ASPNET_1.DbFiles.Contexts;
using SP_ASPNET_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SP_ASPNET_1.DbFiles.Repositories.RepositoryDecorators
{
    public class UserRepository : BaseRepository<User>
    {
        UserManager<User> manager;
        public UserRepository(IceCreamBlogContext context):base(context)
        {
            manager = new UserManager<User>(new UserStore<User>(context));
        }

        public new async  void Insert(User user)
        {
            var userIdentity = await manager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            
        }
    }
}