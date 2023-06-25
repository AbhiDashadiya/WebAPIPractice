namespace WebAPI.Migrations
{
	using System.Data.Entity.Migrations;
	using WebAPI.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<WebAPI.DataContext.StudentDBContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(WebAPI.DataContext.StudentDBContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method
			//  to avoid creating duplicate seed data.

			for (int i = 1; i <= 10; i++)
			{
				context.Students.Add(new Student()
				{
					ID = i,
					Name = $"Student{i * 10 * (0.5)}",
					Email = $"Hello{i}@hotmail.com",
				});
			}

			context.SaveChanges();
		}
	}
}
