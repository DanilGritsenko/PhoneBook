using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class Models
    {
        public class RegisterModel
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public int Age { get; set; }
        }
    }
}