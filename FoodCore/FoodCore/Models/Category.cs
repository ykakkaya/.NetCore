using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodCore.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ")]
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Food> Foods { get; set; }
    }
}
