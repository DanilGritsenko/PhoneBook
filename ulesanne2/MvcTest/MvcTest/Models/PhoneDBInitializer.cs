using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class PhoneDBInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext db)
        {
            db.Phones.Add(new Phone { Name = "Danil", Surname = "Gritsenko", Number = "+37256687745", Email = "danil.gritsenko3@gmail.com" });
            db.Phones.Add(new Phone { Name = "Vladimir", Surname = "Trohhalev", Number = "+37265835932", Email = "trohhalev@gmail.com" });
            db.Phones.Add(new Phone { Name = "Daniil", Surname = "Vatsyk", Number = "+37256651325", Email = "vatsyk@gmail.com" });

            base.Seed(db);
        }
    }
}