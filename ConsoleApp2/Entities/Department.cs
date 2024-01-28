using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ConsoleApp2.Entities;
public class Department
{
    public int Id { get; set; }

    [Required]
    [Range(1, 5)]
    public int Building { get; set; }

    [Required]
    [Column(TypeName = "money")]
    [DefaultValue(0)]
    public decimal Financing { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    public int FacultyId { get; set; }

    public Faculty Faculty { get; set; }
}
