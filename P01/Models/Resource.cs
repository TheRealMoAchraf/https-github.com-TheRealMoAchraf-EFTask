using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TaskMigration.Models
{
    public enum ResourceType
    {
        Video, Presentation, Document,Other
    }
    internal class Resource
    {
        public int ResourceId { get; set; }
        [Unicode(true)]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Unicode(false)]
        public string Url { get; set; } = string.Empty;
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

    }
}
