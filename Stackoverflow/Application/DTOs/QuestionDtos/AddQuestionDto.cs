global using Domain;
namespace Application.DTOs.QuestionDtos;

public class AddQuesitonDto
{
    public string Title { get; set; } = string.Empty!;
    public string Body { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty!;

    public static implicit operator Question(AddQuesitonDto addQuesitonDto)
    => new(){
        
    }
}