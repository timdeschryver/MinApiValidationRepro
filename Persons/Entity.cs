using System;
using System.ComponentModel.DataAnnotations;

namespace MinApiValidationRepro.Persons;

public class Entity
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}
