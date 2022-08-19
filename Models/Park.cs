using System.ComponentModel.DataAnnotations;

namespace ParksDirectory.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Description { get; set; }
  }
}