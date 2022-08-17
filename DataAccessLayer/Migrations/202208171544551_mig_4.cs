﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterSatatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterSatatus");
        }
    }
}
