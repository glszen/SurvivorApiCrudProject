﻿using System.ComponentModel.DataAnnotations;

namespace SurvivorProject.Models
{
    public class Category
    {
    [Key]
    public int Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Name { get; set; }

     public ICollection<Competitor> Competitors { get; set; }

    }
}
