﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminUser { get; set; }
        public int AdminPassword { get; set; }
    }
}