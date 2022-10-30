using System.ComponentModel.DataAnnotations;

namespace FoodCore.Models
{
	public class Admin
	{
		[Key]
		public int AdminId { get; set; }
		[StringLength(20)]
		public string AdminUserName { get; set; }
		[StringLength(15)]
		public string AdminPassword { get; set; }
		[StringLength(1)]
		public string AdminRole { get; set; }
	}
}
