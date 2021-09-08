using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Models
{
    public class CommentCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Enter at least two characters")]
        [MaxLength(800, ErrorMessage ="There are too many character in this field")]
        public string Text { get; set; }
        
        public int PostId { get; set; }
    }
}
