using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities;
public class Faculty
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<Department> Departments { get; set; }
}
