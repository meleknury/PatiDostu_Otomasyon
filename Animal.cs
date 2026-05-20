using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_Animal")]
public class Animal
{
    [Key]
    public int Animal_Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Animal_Name { get; set; }

    [Required]
    public int Animal_Age { get; set; }

    [Required]
    [MaxLength(100)]
    public string Animal_Region { get; set; }

    public int Category_Id { get; set; }
    public virtual Category Category { get; set; }

    public virtual ICollection<CareRecord> CareRecords { get; set; }
}