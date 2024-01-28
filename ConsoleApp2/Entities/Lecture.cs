using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities;
public class Lecture
{
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    [Required]
    public int SubjectId { get; set; }

    public Subject Subject { get; set; }

    [Required]
    public int TeacherId { get; set; }

    public Teacher Teacher { get; set; }
}
