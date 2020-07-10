using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SP_ASPNET_1.Models;

namespace SP_ASPNET_1.DbFiles.Contexts
{
    public class IceCreamBlogContext: IdentityDbContext<User>
    {
        public IceCreamBlogContext() : base("name=IceCreamBlogDB")
        {

        }

      
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
       
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         
        }

        public System.Data.Entity.DbSet<SP_ASPNET_1.ViewModels.UserViewModel> UserViewModels { get; set; }
    }

    public class User : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public override string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Like> Likes { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Surname}";
        }

    }
}