using Microsoft.Ajax.Utilities;
using SP_ASPNET_1.DbFiles.UnitsOfWork;
using SP_ASPNET_1.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SP_ASPNET_1.DbFiles.Operations
{
    public class LikeOperations
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();

        public int IncrementLikes(string userId,int postId)
        {
            
            if (true)
            {
               
                
            }
            else
            {
                _unitOfWork.LikeSchoolRepository.Insert(new Models.Like() { FK_UserId = userId, FK_BlogPostID = postId });
            }
           
            _unitOfWork.Save();
            var x = NumberOfLikesForPost(postId);
            return x;
        }
        public int NumberOfLikesForPost(int postId)
        {
          return  _unitOfWork.LikeSchoolRepository.Get(l => l.FK_BlogPostID == postId).Count();
        }

        public int NumberOfLikesForUser(string userId)
        {
           return _unitOfWork.LikeSchoolRepository.Get(l => l.FK_UserId == userId).Count();
        }

        public ICollection<Like> LikesForUser(string userId)
        {
            return _unitOfWork.LikeSchoolRepository.Get(l => l.FK_UserId == userId).ToList();
        }
    }
}