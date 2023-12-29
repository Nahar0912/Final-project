﻿namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.DoctContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.DoctContext context)
        {
            for (int i = 1; i <= 20; i++)
            {
                context.Doctors.AddOrUpdate(new Models.Doctor
                {
                    Uname = Guid.NewGuid().ToString().Substring(0, 15),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 15),
                    Password = Guid.NewGuid().ToString().Substring(0, 6),
                    Address = Guid.NewGuid().ToString().Substring(0, 8),
                    Phonenumber = Guid.NewGuid().ToString().Substring(0, 11)


                });
                    }
        }
    }
}
