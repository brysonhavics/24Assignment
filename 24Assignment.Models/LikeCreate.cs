﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Assignment.Models
{
    public class LikeCreate
    {

        [Required]
        public Guid OwnerId { get; set; }
        public int PostId { get; set; }

    }
}
