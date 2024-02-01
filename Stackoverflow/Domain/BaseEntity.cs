using System.ComponentModel.DataAnnotations;

namespace Domain;

public class BaseEntity
{
    [Key, Required]
    public int Id { get; set; }
}
