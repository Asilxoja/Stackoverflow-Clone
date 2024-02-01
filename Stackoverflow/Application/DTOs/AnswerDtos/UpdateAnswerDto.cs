using Domain.Entities.Identity;
using Domain;

namespace Application.DTOs.AnswerDtos;

public class UpdateAnswerDto : BaseDto
{
    public string Body { get; set; } = string.Empty!;
    public string UserId { get; set; } = string.Empty!;

    public ApplicationUser User { get; set; } = new();
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    public ICollection<Saved> Saveds { get; set; } = new List<Saved>();
    public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public static implicit operator Answer(UpdateAnswerDto answer)
        => new()
        {
            Answers = answer.Answers,
            Saveds = answer.Saveds,
            Users = answer.Users,
            Comments = answer.Comments,
            Body = answer.Body,
            User = answer.User,
            Id = answer.Id,
            UserId = answer.UserId
        };

    public static implicit operator UpdateAnswerDto(Answer answer)
        => new()
        {
            Answers = answer.Answers,
            Saveds = answer.Saveds,
            Users = answer.Users,
            Comments = answer.Comments,
            Body = answer.Body,
            User = answer.User,
            Id = answer.Id,
            UserId = answer.UserId
        };
}
