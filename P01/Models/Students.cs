using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMigration.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        [Unicode(true)]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "varchar(10)")]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
        public List<Homework> Homeworks { get; set; } = [];
        public List<StudentCourse> studentCourses { get; set; } = [];
    }
}
