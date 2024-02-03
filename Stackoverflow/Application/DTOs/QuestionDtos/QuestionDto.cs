global using Domain.Entities.Identity;

namespace Application.DTOs.QuestionDtos;

public class QuestionDto : BaseDto
{
    public string Title { get; set; } = string.Empty!;
    public string Body { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty!;

    public ApplicationUser User { get; set; } = new();

    public static implicit operator Question(QuestionDto question)
        => new()
        {
            Title = question.Title,
            Body = question.Body,
            UserId = question.UserId,
            User = question.User,
            Id = question.Id,
        };

    public static implicit operator QuestionDto(Question question)
        => new()
        {
            Title = question.Title,
            Body = question.Body,
            UserId = question.UserId,
            Id = question.Id,
            User = question.User
        };
}
