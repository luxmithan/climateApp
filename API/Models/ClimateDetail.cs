using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
  public class ClimateDetail
  {
    [Key]
    public int ClimateDetailId { get; set; }

    [Required]
    [Column(TypeName = "varchar(30)")]
    public string ClimateName { get; set; }

    [Required]
    [Column(TypeName = "int(3)")]
    public int GlobalRadiation { get; set; }

    [Required]
    [Column(TypeName = "int(2)")]
    public int OutTemp { get; set; }

    [Required]
    [Column(TypeName = "int(3)")]
    public int OutCoefficient { get; set; }

    [Required]
    [Column(TypeName = "int(2)")]
    public int InTemp { get; set; }

    [Required]
    [Column(TypeName = "int(3)")]
    public int InCoefficient { get; set; }
  }
}