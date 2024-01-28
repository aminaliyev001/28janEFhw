using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ConsoleApp2.Entities;
public class GroupStudent
{
    public int Id { get; set; }

    [Required]
    public int GroupId { get; set; }

    public Group Group { get; set; }

    [Required]
    public int StudentId { get; set; }

    public Student Student { get; set; }
}
