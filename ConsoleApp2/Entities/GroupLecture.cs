using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ConsoleApp2.Entities;
public class GroupLecture
{
    public int Id { get; set; }

    [Required]
    public int GroupId { get; set; }

    public Group Group { get; set; }

    [Required]
    public int LectureId { get; set; }

    public Lecture Lecture { get; set; }
}
