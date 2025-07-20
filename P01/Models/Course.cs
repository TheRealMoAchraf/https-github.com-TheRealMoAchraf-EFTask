using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMigration.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        [Unicode(true)]
        [MaxLength(80)]
        public string Name { get; set; }
        [Unicode(true)]
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
        public List<Resource> Resource { get; set; } = []; 
        public List<Homework> Homeworks { get; set; }= [];
        public List<StudentCourse> studentsCourse { get; set; }= [];
    }
}