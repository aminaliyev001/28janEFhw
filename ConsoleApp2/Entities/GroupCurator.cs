using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ConsoleApp2.Entities;
public class GroupCurator
{
    public int Id { get; set; }

    [Required]
    public int CuratorId { get; set; }

    public Curator Curator { get; set; }

    [Required]
    public int GroupId { get; set; }

    public Group Group { get; set; }
}
