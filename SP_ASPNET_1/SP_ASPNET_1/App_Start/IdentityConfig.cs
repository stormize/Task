using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;
using SP_ASPNET_1.DbFiles.Contexts;
using SP_ASPNET_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using static SP_ASPNET_1.App_Start.IdentityConfig;

namespace SP_ASPNET_1.App_Start
{
    public class IdentityConfig
    {
        IceCreamBlogContext ctx = new IceCreamBlogContext();
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(() => new IceCreamBlogContext());
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
            app.CreatePerOwinContext<RoleManager<AppRole>>((options, context) =>
                new RoleManager<AppRole>(
                    new RoleStore<AppRole>(context.Get<IceCreamBlogContext>())));

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login")
            });
            CreateRoles();
        }
        public void CreateRoles()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));
            IdentityRole role;
            if (!roleManager.RoleExists("Admin"))
            {
                role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Author"))
            {
                role = new IdentityRole();
                role.Name = "Author";
                roleManager.Create(role);
            }
            if(!roleManager.RoleExists("User"))
            {
                role = new IdentityRole();
                role.Name = "User";
                roleManager.Create(role);
            }

        }

        public class ApplicationUserManager : UserManager<User>
        {
            public ApplicationUserManager(IUserStore<User> store)
                : base(store)
            {
            }

            // this method is called by Owin therefore this is the best place to configure your User Manager
            public static ApplicationUserManager Create(
                IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
            {
                var manager = new ApplicationUserManager(
                    new UserStore<User>(context.Get<IceCreamBlogContext>()));

                // optionally configure your manager
                // ...

                return manager;
            }
        }
    }
    public class ApplicationSignInManager : SignInManager<User, string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
    }
}