﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Models
{
    public class ClassModel
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(255, MinimumLength=1)]
        public string Name { get; set; }
        [Required]
        [Range(3, 6)]
        public int Credits { get; set; }
    }
}