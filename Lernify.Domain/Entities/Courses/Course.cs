﻿using System.ComponentModel.DataAnnotations;

namespace Lernify.Domain.Entities.Course
{
     public class Course
     {
          public int Id { get; set; }
          [Required]
          public string Name { get; set; }
          [Required]
          public string ImageUrl { get; set; } //
          [Required]
          public string Teacher { get; set; }
          [Required]
          //Numarul de ore
          public string Lectures { get; set; }
          [Required]
          public string Language { get; set; }
          [Required]
          public string Description { get; set; }
          [Required]
          public double Price { get; set; }

     }
}