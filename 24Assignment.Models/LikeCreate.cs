using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Models
{
    public class LikeCreate
    {
        public Guid OwnerId { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}