using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities;
public class Subject
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
}
