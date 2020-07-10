namespace SP_ASPNET_1.Migrations
{
    using Microsoft.AspNet.Identity;
    using SP_ASPNET_1.DbFiles.Contexts;
    using SP_ASPNET_1.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SP_ASPNET_1.DbFiles.Contexts.IceCreamBlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SP_ASPNET_1.DbFiles.Contexts.IceCreamBlogContext context)
        {
           
                //  This method will be called after migrating to the latest version.
                context.ProductLines.AddOrUpdate(x => x.Title, new ProductLine
                {
                    Title = "All Time Classic",
                    Description = "One morning, when Gregor Samsa woke from troubled dreams, he found himself transformed in his bed into a horrible vermin. He lay.",
                    ProductItems = new List<ProductItem>()
                {
                    new ProductItem()
                    {
                        Title = "kiwi",
                        ImageAlt = "kiwi icecream",
                        ImageURL = "kiwi.jpg",

                    },
                    new ProductItem()
                    {
                        Title = "mango",
                        ImageAlt = "mango icecream",
                        ImageURL = "mango.jpg",

                    },
                    new ProductItem()
                    {
                        Title = "cantaloupe",
                        ImageAlt = "cantaloupe icecream",
                        ImageURL = "cantaloupe.jpg",

                    }
                }
                });
                context.ProductLines.AddOrUpdate(x => x.Title, new ProductLine
                {
                    Title = "Berry Special",
                    Description = "On his armour-like back, and if he lifted his head a little he could see his brown belly, slightly domed and divided by arches.",
                    ProductItems = new List<ProductItem>()
                {
                    new ProductItem()
                    {
                        Title = "blackberry",
                        ImageAlt = "blackberry icecream",
                        ImageURL = "blackberry.jpg",

                    },
                    new ProductItem()
                    {
                        Title = "strawberry",
                        ImageAlt = "strawberry icecream",
                        ImageURL = "strawberry.jpg",

                    },
                    new ProductItem()
                    {
                        Title = "blueberry",
                        ImageAlt = "blueberry icecream",
                        ImageURL = "blueberry.jpg",

                    }
                }
                });
                context.ProductLines.AddOrUpdate(x => x.Title, new ProductLine
                {
                    Title = "Fruit Blast",
                    Description = "Into stiff sections. The bedding was hardly able to cover it and seemed ready to slide off any moment. His many legs, pitifully.",
                    ProductItems = new List<ProductItem>()
                {
                    new ProductItem()
                    {
                        Title = "grape",
                        ImageAlt = "grape icecream",
                        ImageURL = "grapes.jpg",

                    },
                    new ProductItem()
                    {
                        Title = "apple",
                        ImageAlt = "apple icecream",
                        ImageURL = "green-apple.jpg",

                    },
                    new ProductItem()
                    {
                        Title = "pineapple",
                        ImageAlt = "pineapple icecream",
                        ImageURL = "pineapple.jpg",

                    }
                }
                });


            
                context.Users.AddOrUpdate(new User() { Id = "018e6aec-500f-47f9-ab0f-6e36125a0e12", Name = "Alejandra", Surname = "Biagi" });
                context.Users.AddOrUpdate(new User() { Name = "Alejandra", Surname = "Yezafovich" });
                context.Users.AddOrUpdate(new User() { Name = "Moe", Surname = "Zima" });
                context.Users.AddOrUpdate(new User() { Name = "Jeanna", Surname = "Fawson" });
                context.Users.AddOrUpdate(new User() { Name = "Matteo", Surname = "Theis" });
                context.Users.AddOrUpdate(new User() { Name = "Shanie", Surname = "Enderby" });
                context.Users.AddOrUpdate(new User() { Name = "Jeffrey", Surname = "Fladgate" });
                context.Users.AddOrUpdate(new User() { Name = "Kippy", Surname = "Prendergast" });
                context.Users.AddOrUpdate(new User() { Name = "Saloma", Surname = "Bourne" });
                context.Users.AddOrUpdate(new User() { Name = "Keane", Surname = "Hryniewicz" });
                context.Users.AddOrUpdate(new User() { Name = "Lucia", Surname = "Bye" });
                context.Users.AddOrUpdate(new User() { Name = "Daryl", Surname = "Blazewicz" });
                context.Users.AddOrUpdate(new User() { Name = "Olwen", Surname = "Eblein" });
                context.Users.AddOrUpdate(new User() { Name = "Juliana", Surname = "Knightsbridge" });
                context.Users.AddOrUpdate(new User() { Name = "Vito", Surname = "Adriaens" });
                context.Users.AddOrUpdate(new User() { Name = "Jasmin", Surname = "Bambrick" });
                context.Users.AddOrUpdate(new User() { Name = "Bambi", Surname = "Jakoub" });
                context.Users.AddOrUpdate(new User() { Name = "Candide", Surname = "Duffell" });
                context.Users.AddOrUpdate(new User() { Name = "Alanah", Surname = "Selland" });
                context.Users.AddOrUpdate(new User() { Name = "Colver", Surname = "Rushton" });
                context.Users.AddOrUpdate(new User() { Name = "Jodie", Surname = "Madgewick" });
                context.Users.AddOrUpdate(new User() { Name = "Powell", Surname = "Boutton" });
                context.Users.AddOrUpdate(new User() { Name = "Keith", Surname = "Janz" });
                context.Users.AddOrUpdate(new User() { Name = "Erina", Surname = "Langelaan" });
                context.Users.AddOrUpdate(new User() { Name = "Yorgos", Surname = "Carus" });
                context.Users.AddOrUpdate(new User() { Name = "Catriona", Surname = "Iles" });
                context.Users.AddOrUpdate(new User() { Name = "Nettle", Surname = "Brabon" });
                context.Users.AddOrUpdate(new User() { Name = "Quent", Surname = "Capron" });
                context.Users.AddOrUpdate(new User() { Name = "Linnell", Surname = "Garaghan" });
                context.Users.AddOrUpdate(new User() { Name = "Marylynne", Surname = "Champion" });
                context.Users.AddOrUpdate(new User() { Name = "Meryl", Surname = "Grimble" });
                context.Users.AddOrUpdate(new User() { Name = "Emelina", Surname = "Costellow" });
                context.Users.AddOrUpdate(new User() { Name = "Gusty", Surname = "Giddens" });
                context.Users.AddOrUpdate(new User() { Name = "Roderich", Surname = "Solway" });
                context.Users.AddOrUpdate(new User() { Name = "Lucinda", Surname = "Fowgies" });
                context.Users.AddOrUpdate(new User() { Name = "Aryn", Surname = "Baylis" });
                context.Users.AddOrUpdate(new User() { Name = "Aurel", Surname = "Lundbeck" });
                context.Users.AddOrUpdate(new User() { Name = "Lamont", Surname = "Jaye" });
                context.Users.AddOrUpdate(new User() { Name = "Hersch", Surname = "Poller" });
                context.Users.AddOrUpdate(new User() { Name = "Fonzie", Surname = "Pietesch" });
                context.Users.AddOrUpdate(new User() { Name = "Bel", Surname = "Hanham" });
                context.Users.AddOrUpdate(new User() { Name = "Pet", Surname = "Doles" });
                context.Users.AddOrUpdate(new User() { Name = "Margery", Surname = "Burnell" });
                context.Users.AddOrUpdate(new User() { Name = "Edlin", Surname = "Scollan" });
                context.Users.AddOrUpdate(new User() { Name = "Rhodie", Surname = "Quarlis" });
                context.Users.AddOrUpdate(new User() { Name = "Tedd", Surname = "Proven" });
                context.Users.AddOrUpdate(new User() { Name = "Ely", Surname = "Sidebotton" });
                context.Users.AddOrUpdate(new User() { Name = "Farris", Surname = "Staddom" });
                context.Users.AddOrUpdate(new User() { Name = "Eloise", Surname = "Vlk" });

                
           

           

                context.SaveChanges();
            
               

            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-14592477), ImageUrl = "post-2.jpg", Content = "24aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.24 24" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-56461870), ImageUrl = "post-2.jpg", Content = "18aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.18 18" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-35264963), ImageUrl = "post-1.jpg", Content = "26aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.26 26" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-14096753), ImageUrl = "post-2.jpg", Content = "39aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.39 39" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-5275829), ImageUrl = "post-2.jpg", Content = "19aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.19 19" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-17646789), ImageUrl = "post-2.jpg", Content = "29aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.29 29" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-38240999), ImageUrl = "post-1.jpg", Content = "28aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.28 28" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-39669202), ImageUrl = "post-1.jpg", Content = "29aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.29 29" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-8937357), ImageUrl = "post-3.jpg", Content = "19aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.19 19" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-35701712), ImageUrl = "post-3.jpg", Content = "34aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.34 34" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-46595340), ImageUrl = "post-3.jpg", Content = "29aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.29 29" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-1767433), ImageUrl = "post-1.jpg", Content = "17aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.17 17" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-1509963), ImageUrl = "post-2.jpg", Content = "25aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.25 25" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-42775653), ImageUrl = "post-2.jpg", Content = "16aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.16 16" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-25294727), ImageUrl = "post-1.jpg", Content = "30aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.30 30" });
            context.BlogPosts.AddOrUpdate(new BlogPost() {  DateTime = DateTime.Now.AddSeconds(-22180776), ImageUrl = "post-2.jpg", Content = "33aTakes much more effort than doing your own business at home, and on top of that there's the curse of travelling, worries about making train connections, bad and irregular food, contact with different people all the time so that you can never get to know anyone or become friendly. \n\n With them. It can all go to Hell!\" He felt a slight itch up on his belly; pushed himself slowly up on his back towards the headboard so that he could lift his head better; found where the itch was, and saw that it was covered with lots of little white spots which he didn't know what to make of; and when he.33 33" });
        
            context.SaveChanges();

        }
        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data.
    }
    }

