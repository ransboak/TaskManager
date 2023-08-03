using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Shared.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [Column (TypeName = "nvarchar(100)")]
        public string TaskName { get; set; }
        [Required]

        [Column(TypeName = "date")]
        public DateTime Deadline { get; set; }

        public bool IsCompleted { get; set; }
    }
}
