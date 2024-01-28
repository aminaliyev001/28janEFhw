using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities;
public class Curator
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [Required]
    [MaxLength(200)]
    public string Surname { get; set; }
}
