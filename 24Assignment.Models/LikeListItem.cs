using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Models
{
    public class LikeListItem
    {
        public Guid OwnerId { get; set; }
        public int Id { get; set; }


    }
}