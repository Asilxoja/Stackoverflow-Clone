namespace Application.DTOs.SavedDtos;

public class AddSavedDto
{
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }

    public string UserId { get; set; } = string.Empty!;

    public static implicit operator Saved(AddSavedDto dto) =>
        new()
        {
            QuestionId = dto.QuestionId,
            AnswerId = dto.AnswerId,
            UserId = dto.UserId,
        };
}
