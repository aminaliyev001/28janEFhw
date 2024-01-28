using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities;
public class Group
{
    public int Id { get; set; }

    [Required]
    [MaxLength(10)]
    public string Name { get; set; }

    [Required]
    [Range(1, 5)]
    public int Year { get; set; }

    [Required]
    public int DepartmentId { get; set; }

    public Department Department { get; set; }
}