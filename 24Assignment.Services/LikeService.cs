using _24Assignment.Data;
using _24Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Services
{
    public class LikeService
    {
        private readonly Guid _OwnerId;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public LikeService(Guid OwnerId)
        {
            _OwnerId = OwnerId;
        }

        public bool CreateLike(LikeCreate model)
        {
            var entity =
                new Like()
                {
                    OwnerId = _OwnerId,
                    PostId = model.PostId
                };

            _context.Likes.Add(entity);
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<LikeListItem> GetLikes()
        {
            var query =
                _context
                .Likes
                .Where(e => e.OwnerId == _OwnerId)
                .Select(
                    e =>
                    new LikeListItem()
                    {
                        OwnerId = e.OwnerId,
                        Id = e.PostId,

                    }
                ).ToList();
            return query;
        }
    }
}

