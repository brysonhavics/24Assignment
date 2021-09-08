using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Display(Name = "Comments")]
        public List<CommentListItem> CommentsList { get; set; }
        [Display(Name = "Likes")]
        public int Likes { get; set; }
    }
}
