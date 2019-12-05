using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class Group
    {
        [Key]
        public int GId { get; set; }

        [Required(ErrorMessage = "Необходимо название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Необходим ИД пользователя")]
        public int UId { get; set; }
    }
}