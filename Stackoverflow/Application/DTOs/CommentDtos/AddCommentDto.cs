namespace Application.DTOs.CommentDtos;

public class AddCommentDto
{
    public string Body { get; set; } = string.Empty!;
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }
    public string UserId { get; set; } = string.Empty!;

    public static implicit operator Comment(AddCommentDto addCommentDto)
    => new()
    {
        Body = addCommentDto.Body,
        QuestionId = addCommentDto.QuestionId,
        AnswerId = addCommentDto.AnswerId,
        UserId = addCommentDto.UserId
    };
}