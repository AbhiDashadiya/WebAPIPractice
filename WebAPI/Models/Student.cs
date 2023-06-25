using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;

namespace WebAPI.Models
{
	[TableName("Student")]
	public class Student
	{
		[Key]
		public int ID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Email { get; set; }


	}
}