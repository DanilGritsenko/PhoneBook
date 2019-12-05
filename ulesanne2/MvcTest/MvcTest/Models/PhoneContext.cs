using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class PhoneContext : DbContext
    {
        public PhoneContext() :
            base("PhoneContext")
        { }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}