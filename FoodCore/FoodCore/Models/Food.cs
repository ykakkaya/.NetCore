using System.ComponentModel.DataAnnotations;

namespace FoodCore.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required(ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ")]
        public string FoodName { get; set; }
        public string FoodDesc { get; set; }
        public double FoodPrice { get; set; }
        public string FoodImgUrl { get; set; }
        public int FoodStock { get; set; }
        public bool FoodStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
