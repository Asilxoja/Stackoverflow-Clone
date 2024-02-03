global using Application.DTOs.QuestionDtos;

namespace Application.Interfaces;

public interface IQuestionService
{
    Task<List<QuestionDto>> GetAllAsync();
    Task<QuestionDto> GetByIdAsync(int id);
    Task AddAsync(AddQuesitonDto addQuesiton);
    Task<QuestionDto> UpdateAsync(QuestionDto questionDto);
    Task DeleteAsync(int id);
}
