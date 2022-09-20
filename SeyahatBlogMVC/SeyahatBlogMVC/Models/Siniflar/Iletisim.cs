using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string IletisimAdSoyad { get; set; }
        public string IletisimMail { get; set; }
        public string IletisimMesaj { get; set; }

    }
}