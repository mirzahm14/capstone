﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Semester")]
        public int SemesterId { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required]
        [StringLength(7)]
        public required string Code { get; set; }

        [Required]
        [Range(1, 14, ErrorMessage = "Semester must be between 1 and 14.")]
        public SemesterEnum Semesters { get; set; }
        public List<CourseType> CourseTypes { get; set; } = new List<CourseType>();

        public enum SemesterEnum
        {
            One = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Eleven,
            Twelve,
            Thirteen,
            Fourteen
        }
    }
}
