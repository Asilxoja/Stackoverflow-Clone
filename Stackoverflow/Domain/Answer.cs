using Domain.Entities.Identity;

namespace Domain;

public class Answer : BaseEntity
{
    public string Body { get; set; } = string.Empty!;
    public string UserId { get; set; } = string.Empty!;

    public ApplicationUser User { get; set; } = new();
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    public ICollection<Saved> Saveds { get; set; } = new List<Saved>();
    public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
