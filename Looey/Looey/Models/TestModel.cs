﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Looey.Models
{
    public class TestModel
    {
        [Required]
        [DisplayName("Test propaaaty")]
        public int Property { get; set; }
    }
}