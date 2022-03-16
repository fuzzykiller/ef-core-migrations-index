using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace efcoretest.Model;

[Index(nameof(Name), IsUnique = true, Name = "IX_Name_Unique")]
public class Minute
{
    [Key]
    public int Minute_Id { get; set; }

    public string Name { get; set; }
}