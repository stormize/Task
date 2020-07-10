using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SP_ASPNET_1.App_Start;
using SP_ASPNET_1.DbFiles.Contexts;
using SP_ASPNET_1.DbFiles.Operations;
using SP_ASPNET_1.DbFiles.Repositories;
using SP_ASPNET_1.DbFiles.Repositories.RepositoryDecorators;
using SP_ASPNET_1.Models;

namespace SP_ASPNET_1.DbFiles.UnitsOfWork
{
    public interface IUnitOfWork
    {
        IRepository<BlogPost> BlogPostSchoolRepository { get; }
        UserManager<User> UserSchoolRepository { get; }
        IRepository<ProductLine> ProductLineSchoolRepository { get; }
        IRepository<ProductItem> ProductItemSchoolRepository { get; }
    }
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IceCreamBlogContext _context = new IceCreamBlogContext();

        private UserManager<User> _userSchoolRepository;
        private IRepository<BlogPost> _blogPostSchoolRepository;
        private IRepository<ProductLine> _productLineSchoolRepository;
        private IRepository<ProductItem> _productItemSchoolRepository;
        private IRepository<Like> _likeSchoolRepository;
        private IRepository<Comment> _commentSchoolRepository;

        public IRepository<Comment> CommentSchoolRepository
        {
            get
            {
                if (this._commentSchoolRepository == null)
                {
                    this._commentSchoolRepository = new BaseRepository<Comment>(this._context);
                }
                return this._commentSchoolRepository;
            }
        }
        public IRepository<Like> LikeSchoolRepository
        { get {
                if (this._likeSchoolRepository == null)
                {
                    this._likeSchoolRepository = new BaseRepository<Like>(this._context);
                }
                return this._likeSchoolRepository;
            }  }
        public IRepository<BlogPost> BlogPostSchoolRepository
        {
            get
            {
                if (this._blogPostSchoolRepository == null)
                {
                    this._blogPostSchoolRepository = new BlogPostRepository(this._context);
                }
                return _blogPostSchoolRepository;
            }
        }

        public UserManager<User> UserSchoolRepository
        {
            get
            {
                if (this._userSchoolRepository == null)
                {
                    this._userSchoolRepository = new UserManager<User>(new UserStore<User>(this._context));
                }
                return _userSchoolRepository;
            }
        }

        public IRepository<ProductLine> ProductLineSchoolRepository
        {
            get
            {
                if (this._productLineSchoolRepository == null)
                {
                    this._productLineSchoolRepository = new BaseRepository<ProductLine>(this._context);
                }
                return _productLineSchoolRepository;
            }
        }

        public IRepository<ProductItem> ProductItemSchoolRepository
        {
            get
            {
                if (this._productItemSchoolRepository == null)
                {
                    this._productItemSchoolRepository = new BaseRepository<ProductItem>(this._context);
                }
                return _productItemSchoolRepository;
            }
        }
   
        public void Save()
        {
            this._context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}