using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Data
{
    public class Like
    {
        public Guid OwnerId { get; set; }
        public int Id { get; set; }

        //[ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        public virtual List<Post> Posts { get; set; }
    }


}
