using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace efcoretest.Model;

[Index(nameof(Name), IsUnique = true, Name = "IX_Name_Unique")]
public class Hour
{
    [Key] public int Hour_Id { get; set; }

    public string Name { get; set; }
}