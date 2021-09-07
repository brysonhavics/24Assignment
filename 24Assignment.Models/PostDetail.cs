using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Assignment.Data;

namespace _24Assignment.Models
{
    public class PostDetail
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        //public virtual List<Comment> Comments { get; set; }
        // publci virtual List<Like> Likes { get; set; }
        public Guid AuthorId { get; set; }
    }
}
