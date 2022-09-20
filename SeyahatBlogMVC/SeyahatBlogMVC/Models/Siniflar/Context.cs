﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Adres>Adreses { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkimizda>Hakkimizdas { get; set; }
        public DbSet<Iletisim>Iletisims { get; set; }
        public DbSet<Yorum>Yorums { get; set; }


    }
}