using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Table_CareRecord")]
public class CareRecord
{
    [Key]
    public int Care_Id { get; set; }

    public int Animal_Id { get; set; }
    public virtual Animal Animal { get; set; }

    public int Volunteer_Id { get; set; }
    public virtual Volunteer Volunteer { get; set; }

    [Required]
    public DateTime Care_Date { get; set; }

    [MaxLength(250)]
    public string Care_Note { get; set; }
}