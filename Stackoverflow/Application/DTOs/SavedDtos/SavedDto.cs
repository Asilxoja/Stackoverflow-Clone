namespace Application.DTOs.SavedDtos;

public class SavedDto : BaseDto
{
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }

    public string UserId { get; set; } = string.Empty!;
    public Answer Answer { get; set; } = new();
    public ApplicationUser User { get; set; } = new();

    public static implicit operator Saved(SavedDto dto) => new()
    {
        QuestionId = dto.QuestionId,
        AnswerId = dto.AnswerId,
        User = dto.User,
        UserId = dto.UserId,
        Answer = dto.Answer,
        Id = dto.Id
    };
}
