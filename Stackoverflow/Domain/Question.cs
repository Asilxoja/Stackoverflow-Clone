using Domain.Entities.Identity;

namespace Domain;

public class Question : BaseEntity
{
    public string Title { get; set; } = string.Empty!;
    public string Body { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty!;

    public ApplicationUser User { get; set; } = new();
}

