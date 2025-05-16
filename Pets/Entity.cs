using System;
using System.ComponentModel.DataAnnotations;

namespace MinApiValidationRepro.Pets;

public class Entity
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Breed { get; set; }
}
