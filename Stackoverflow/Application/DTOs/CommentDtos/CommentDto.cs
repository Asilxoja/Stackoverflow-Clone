namespace Application.DTOs.CommentDtos;

public class CommentDto
{
    public string Body { get; set; } = string.Empty!;
    public int QuestionId { get; set; }
    public int AnswerId { get; set; }
    public string UserId { get; set; } = string.Empty!;

    public ApplicationUser UserComment { get; set; } = new();
    
    public Answer Answer { get; set; } = new();

    public static implicit operator Comment(CommentDto commentDto)
    => new()
    {
        Body = commentDto.Body,
        QuestionId = commentDto.QuestionId,
        UserComment = commentDto.UserComment,
        Answer = commentDto.Answer,
        AnswerId = commentDto.AnswerId,
        UserId = commentDto.UserId
    };

    public static implicit operator CommentDto(Comment commentDto)
    => new()
    {
        Body = commentDto.Body,
        QuestionId = commentDto.QuestionId,
        UserComment = commentDto.UserComment,
        Answer = commentDto.Answer,
        AnswerId = commentDto.AnswerId,
        UserId = commentDto.UserId
    };
}