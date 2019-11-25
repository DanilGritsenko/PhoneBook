using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class Phone
    {
        // ID книги
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Необходима фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Необходим номер телефона")]
        public string Number { get; set; }

        public string Email { get; set; }
    }
}