using _24Assignment.Data;
using _24Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Services
{

    public class ReplyService
    {
        private readonly Guid _userId;

        private ApplicationDbContext _context = new ApplicationDbContext();

        public ReplyService(Guid id)
        {
            _userId = id;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity = new Reply() { AuthorId = _userId, CommentId = model.CommentId, Text = model.Text };

            _context.Replies.Add(entity);
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<ReplyListItem> GetReplies(int postId)
        {
            List<ReplyListItem> replies = _context.Replies.Where(r => r.CommentId == postId).Select(t => new ReplyListItem() { Text = t.Text }).ToList();
            return replies;
        }
    }
}
