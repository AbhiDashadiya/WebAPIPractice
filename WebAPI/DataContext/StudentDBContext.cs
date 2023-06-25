using System.Data.Entity;
using WebAPI.Models;

namespace WebAPI.DataContext
{
	public class StudentDBContext : DbContext
	{
		public StudentDBContext() : base("Data Source=ABHIPATEL\\SQLEXPRESS;Initial Catalog =SchoolManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;")
		{

		}

		public DbSet<Student> Students { get; set; }
	}
}