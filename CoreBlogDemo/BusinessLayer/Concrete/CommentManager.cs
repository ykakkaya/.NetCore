using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            commentDal.Insert(comment);
        }

        //public void CommentDelete(Comment comment)
        //{
        //    throw new NotImplementedException();
        //}

        //public void CommentUpdate(Comment comment)
        //{
        //    commentDal.Update(comment);
        //}

        public List<Comment> GetAllList(int id)
        {
            return commentDal.GetListAll(x=> x.BlogID== id);
        }

        //public Comment GetById(int id)
        //{
        //    return commentDal.GetById(id);
        //}
    }
}
