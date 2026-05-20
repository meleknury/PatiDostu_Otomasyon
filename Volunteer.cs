using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_Volunteer")]
public class Volunteer
{
    [Key]
    public int Volunteer_Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Volunteer_Name { get; set; }

    [Required]
    [MaxLength(20)]
    public string Volunteer_Phone { get; set; }

    [Required]
    [MaxLength(100)]
    public string Volunteer_Email { get; set; }

    public virtual ICollection<CareRecord> CareRecords { get; set; }
}