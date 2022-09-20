using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int AnasayfaId { get; set; }
        public string Baslik { get; set; }
        public string Acıklama { get; set; }
    }
}