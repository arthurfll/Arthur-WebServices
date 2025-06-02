using System.ComponentModel.DataAnnotations;

namespace App.Models
{
  public class CategoryTag
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

  }
}

