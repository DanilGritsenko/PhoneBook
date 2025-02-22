﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
    public class UserDbInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Roles.Add( new Role { Id = 1, Name = "admin"});
            db.Roles.Add( new Role { Id = 2, Name = "user"});
            db.Roles.Add(new Role { Id = 3, Name = "guest" });
            db.Users.Add(new User
            {
                Id = 1,
                Email = "admin",
                Password = "admin",
                RoleId = 1

            });

            base.Seed(db);
        }
    }
}