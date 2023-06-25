using System.Web.Http;
using WebAPI.DataContext;
using WebAPI.Models;

namespace WebAPI.Controllers
{
	public class StudentController : ApiController
	{
		StudentDBContext db = new StudentDBContext();

		public class TestClass
		{
			public string test1;
		}

		// GET: Student
		//public IEnumerable<Student> GetStudents()
		//{
		//	return db.Students;
		//}

		// GET : Student/id
		[HttpGet]
		public IHttpActionResult GetStudentDetail([FromBody] TestClass data)
		{
			//Student student = db.Students.Find(id);
			//if (student == null)
			//{
			//	return BadRequest("Data Not Found!");
			//}

			if (data == null)
			{
				return BadRequest("Data is null");
			}

			if (string.IsNullOrEmpty(data.test1) || string.IsNullOrWhiteSpace(data.test1))
			{
				return BadRequest("String is null");
			}

			return Ok("Data Got");
		}


		[HttpPost]
		public IHttpActionResult AddStudent(Student student)
		{
			if (student == null)
			{
				return BadRequest("Data is null");
			}

			db.Students.Add(student);
			if (db.SaveChanges() == 0)
			{
				return BadRequest("Data is not added!😒");
			}

			return Ok("👌Data Saved!👌");

		}

		[HttpDelete]
		public IHttpActionResult RemoveStudent(int id)
		{
			var result = (db.Students.Find(id));



			if (result == null)
			{
				return BadRequest("Data is Invalid");
			}

			db.Students.Remove(result);

			if (result.ID != id)
			{
				return BadRequest("Student Id is invalid!");
			}

			return Ok("Student Deleted!😍");

		}

	}

}