using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlokBaslik { get; set; }
        public DateTime BlokTarih { get; set; }
        public string BlokAciklama { get; set; }
        public string BlogResimUrl { get; set; }
        public ICollection <Yorum> Yorums { get; set; }
    }
}