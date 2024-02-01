using Domain.Entities.Identity;
using Domain;

namespace Application.DTOs.AnswerDtos;

public class AddAnswerDto
{
    public string Body { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;

    public static implicit operator Answer(AddAnswerDto answer)
         => new()
         {
             Body = answer.Body,
             UserId = answer.UserId
         };
}