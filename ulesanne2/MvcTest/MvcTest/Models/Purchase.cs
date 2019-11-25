using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcTest.Models
{
    public class Purchase
    {
        // ID покупки
        public int PurchaseId { get; set; }
        [Required(ErrorMessage = "Пожалуйста, впишите ваше имя")]
        public string Person { get; set; }

        [Required(ErrorMessage = "Пожалуйста, впишите ваш Э-Маил")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Пожалуйста, впишите ваш Э-Маил")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, впишите ваш мобильный номер")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите если вы клиент или нет")]
        public bool? Klient { get; set; }

        public int BookId { get; set; }
        public DateTime Date { get; set; }
    }
}