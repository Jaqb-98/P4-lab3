using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lab3
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        [Column("Name")]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        [Column("Surename")]
        public string Surename { get; set; }

    }
}
