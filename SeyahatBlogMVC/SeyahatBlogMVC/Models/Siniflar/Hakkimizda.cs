using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        public string HakkimizdaFotoUrl { get; set; }
        public string HakkimizdaAciklama { get; set; }
    }
}