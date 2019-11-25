using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class Book
    {
        // ID книги
        public int Id { get; set; }
        // название книги
        [Required(ErrorMessage = "Необходимо название книги")]
        public string Name { get; set; }
        // автор книги
        [Required(ErrorMessage = "Необходимо имя автора")]
        public string Author { get; set; }
        // цена
        [Required(ErrorMessage = "Необходима цена книги")]
        public int Price { get; set; }
        public string Image { get; set; }
        public string File { get; set; }
    }
}