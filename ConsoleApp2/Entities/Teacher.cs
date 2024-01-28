using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities;
public class Teacher
{
    public int Id { get; set; }

    [Required]
    public bool IsProfessor { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal Salary { get; set; }

    [Required]
    [MaxLength(200)]
    public string Surname { get; set; }
}
