using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Data
{
    public class Reply
    {
        public int ReplyId { get; set; }
        public int CommentId { get; set; }
        public string Text { get; set; }
        public Guid AuthoerId { get; set; }
    }
}
