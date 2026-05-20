using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_Category")]
public class Category
{
    [Key]
    public int Category_Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Category_Name { get; set; }

    public virtual ICollection<Animal> Animals { get; set; }
}
