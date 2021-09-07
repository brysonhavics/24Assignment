using _24Assignment.Data;
using _24Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Services
{
    public class CommentService
    {
        private readonly Guid _userId;

        private ApplicationDbContext _context = new ApplicationDbContext();

        public CommentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity = new Comment() { AuthorId = _userId, PostId = model.PostId, Text = model.Text };

            _context.Comments.Add(entity);
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<CommentListItem> GetCommentsById()
        {

        }
    }
}
