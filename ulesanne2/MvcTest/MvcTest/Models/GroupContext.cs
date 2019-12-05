using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class GroupContext : DbContext
    {
            public GroupContext() :
                base("PhoneContext")
            { }
            public DbSet<Group> Groups { get; set; }
    }
}