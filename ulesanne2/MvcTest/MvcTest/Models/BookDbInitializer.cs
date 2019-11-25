using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcTest.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 22, Image="book1.jpg", File="book1.pdf" });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 18, Image="book2.jpg", File = "book2.pdf" });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 15, Image="book3.jpg", File = "book3.pdf" });

            base.Seed(db);
        }
    }
}