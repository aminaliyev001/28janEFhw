namespace ConsoleApp2.Entities;
using System.ComponentModel.DataAnnotations;

public class Student
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [Required]
    [Range(0, 5)]
    public int Rating { get; set; }

    [Required]
    [MaxLength(200)]
    public string Surname { get; set; }
}
