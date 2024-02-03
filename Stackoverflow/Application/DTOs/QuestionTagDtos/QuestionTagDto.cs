namespace Application.DTOs.QuestionTagDtos;

public class QuestionTagDto : BaseDto
{
    public int QuestionId { get; set; }
    public int TagId { get; set; }

    public static implicit operator QuestionTag(QuestionTagDto addQuestionTagDto)
    => new()
    {

        QuestionId = addQuestionTagDto.QuestionId,
        Id = addQuestionTagDto.Id,
        TagId = addQuestionTagDto.TagId
    };
    public static implicit operator QuestionTagDto(QuestionTag addQuestionTagDto)
    => new()
    {
        QuestionId = addQuestionTagDto.QuestionId,
        Id = addQuestionTagDto.Id,
        TagId = addQuestionTagDto.TagId
    };
}