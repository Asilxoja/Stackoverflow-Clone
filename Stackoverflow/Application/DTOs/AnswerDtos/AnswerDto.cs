using Domain.Entities.Identity;
using Domain;

namespace Application.DTOs.AnswerDtos;

public class AnswerDto : BaseDto
{
    public string Body { get; set; } = string.Empty!;
    public string UserId { get; set; } = string.Empty!;

    public ApplicationUser User { get; set; } = new();
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    public ICollection<Saved> Saveds { get; set; } = new List<Saved>();
    public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public static implicit operator Answer(AnswerDto answer)
        => new Answer()
        {
            Body = answer.Body,
            UserId = answer.UserId,
            Id = answer.Id,
            User = answer.User,
            Answers = answer.Answers,
            Saveds = answer.Saveds,
            Users = answer.Users,
            Comments = answer.Comments,
        };

    public static implicit operator AnswerDto(Answer answer)
    => new Answer()
    {
        Body = answer.Body,
        UserId = answer.UserId,
        Id = answer.Id,
        User = answer.User,
        Answers = answer.Answers,
        Saveds = answer.Saveds,
        Users = answer.Users,
        Comments = answer.Comments,
    };
}
