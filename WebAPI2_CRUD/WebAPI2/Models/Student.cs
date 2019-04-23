using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required(ErrorMessage = "Enter data in this field and Submit again*")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Department { get; set; }
    }
}
