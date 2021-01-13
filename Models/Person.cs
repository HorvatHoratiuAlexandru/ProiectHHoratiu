using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectHHoratiu.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Display(Name = "Nume")]
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        public DateTime PostingDate { get; set; }
    }
}
