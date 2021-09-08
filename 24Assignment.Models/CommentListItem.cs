using _24Assignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Models
{
    public class CommentListItem
    {
        public int UserId { get; set; }
        public string Text { get; set; }
        public List<Reply> Replies { get; set; }
    }
}
