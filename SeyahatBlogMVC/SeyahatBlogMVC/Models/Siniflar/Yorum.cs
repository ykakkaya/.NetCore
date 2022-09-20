using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        public string KullaniciAdi{ get; set; }
        public string Mail { get; set; }
        public string Acıklama { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}