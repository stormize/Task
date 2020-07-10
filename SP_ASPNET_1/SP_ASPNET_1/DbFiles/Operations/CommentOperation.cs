using SP_ASPNET_1.DbFiles.UnitsOfWork;
using SP_ASPNET_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SP_ASPNET_1.DbFiles.Operations
{
    public class CommentOperation
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();

       
        internal void Create(Comment comment)
        {
            try
            {
                this._unitOfWork.CommentSchoolRepository.Insert(comment);
                this._unitOfWork.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}