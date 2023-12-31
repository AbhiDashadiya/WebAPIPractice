﻿namespace WebAPI.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class Initial : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Students",
				c => new
				{
					ID = c.Int(nullable: false, identity: true),
					Name = c.String(),
					Email = c.String(),
				})
				.PrimaryKey(t => t.ID);

		}

		public override void Down()
		{
			DropTable("dbo.Students");
		}
	}
}
