global using Application.Interfaces;
global using Infrastructure.Interface;
using Application.Common.Exceptions;
using Application.Common.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Application.Services;

public class QuestionService(IUnitOfWork unitOfWork) : IQuestionService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task AddAsync(AddQuesitonDto addQuesiton)
    {
        if (addQuesiton == null)
        {
            throw new Exception("Questioln is null");
        }

        var questions = await _unitOfWork.QuestionInterface.GetAllAsync();
        var question = (Question)addQuesiton;

        if (!question.IsExist(questions))
        {
            throw new Exception("Question with the same title already exists.");
        }

        try
        {
            await _unitOfWork.QuestionInterface.AddAsync(question);
            await _unitOfWork.SaveAsync();
        }
        catch (CustomException ex)
        {
            throw new Exception(ex.Message);
        }

        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task DeleteAsync(int id)
    {
        var questonTask = _unitOfWork.QuestionInterface.GetByIdAsync(id);
        var queston = await questonTask;

        if (queston != null)
        {
            throw new Exception("eeeeee");
        }

        try
        {
            await _unitOfWork.QuestionInterface.DeleteAsync(queston!);
            await _unitOfWork.SaveAsync();
        }
        catch (CustomException ex)
        {
            throw new Exception(ex.Message);
        }

        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    public async Task<List<QuestionDto>> GetAllAsync()
    {
        var questons = await _unitOfWork.QuestionInterface.GetAllAsync();

        return questons.Select(g => (QuestionDto)g).ToList();
    }
    

    public async Task<QuestionDto> GetByIdAsync(int id)
    {
        var question = await _unitOfWork.QuestionInterface.GetByIdAsync(id);
        if (question == null)
        {
            throw new ArgumentNullException("Updated question information is null");
        }
        return (QuestionDto)question;
    }

    public async Task<QuestionDto> UpdateAsync(QuestionDto questionDto)
    {
        if (questionDto == null)
            throw new CustomException($"null");

        var question = await _unitOfWork.QuestionInterface.GetByIdAsync(questionDto.Id);
        var map = (Question)questionDto;

        await _unitOfWork.QuestionInterface.UpdateAsync(map);
        await _unitOfWork.SaveAsync();

        return question;
    }
}
