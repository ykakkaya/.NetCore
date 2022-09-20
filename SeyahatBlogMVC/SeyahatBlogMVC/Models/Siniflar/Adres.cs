using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatBlogMVC.Models.Siniflar
{
    public class Adres
    {
        [Key]
        public int AdresId { get; set; }
        public string AdresBaslik { get; set; }
        public string AdresAciklama { get; set; }
        public string AdresMail { get; set; }
        public string AdresTelefon { get; set; }
        public string AdresKonum { get; set; }


    }
}