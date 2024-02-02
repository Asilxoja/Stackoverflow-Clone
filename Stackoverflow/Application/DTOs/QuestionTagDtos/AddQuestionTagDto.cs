namespace Application.DTOs.QuestionTagDtos;

public class AddQuestionTagDto
{
 
    public int QuestionId { get; set; }
    public int TagId { get; set; }

    public static implicit operator QuestionTag(AddQuestionTagDto addQuestionTagDto)
    => new()
    {
        QuestionId = addQuestionTagDto.QuestionId,
        TagId = addQuestionTagDto.TagId
    };
}