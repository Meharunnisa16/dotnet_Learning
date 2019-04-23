using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Models
{
    public class StudentData:DbContext
    {
        public StudentData(DbContextOptions<StudentData> options): base(options)
        {

        }
         
        
        public DbSet<Student> Students { get; set; }
    }
}
