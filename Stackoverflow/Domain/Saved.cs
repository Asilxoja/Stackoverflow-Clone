using Domain.Entities.Identity;

namespace Domain;

public class Saved : BaseEntity
{
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }

    public string UserId { get; set; } = string.Empty!;
    public Answer Answer { get; set; } = new();
    public ApplicationUser User { get; set; } = new();
}
