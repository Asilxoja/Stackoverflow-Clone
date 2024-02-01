using Domain.Entities.Identity;

namespace Domain;

public class Comment : BaseEntity
{
    public string Body { get; set; } = string.Empty!;
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }
    public string UserId { get; set; } = string.Empty!;

    public ApplicationUser UserComment { get; set; } = new();
    
    public Answer Answer { get; set; } = new();
}
