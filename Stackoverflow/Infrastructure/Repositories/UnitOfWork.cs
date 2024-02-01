
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UnitOfWork(IQuestionInterface questionInterface,
                        IAnswerInterface answerInterface,
                        ISavedInterface savedInterface,
                        ICommetInterface commetInterface,
                        IQuestionTagInterface questionTagInterface,
                        ITag tag,
                        ApplicationDbContext dbContext) : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public IAnswerInterface AnswerInterface { get; } = answerInterface;

    public IQuestionTagInterface QuestionTagInterface { get; } = questionTagInterface;

    public IQuestionInterface QuestionInterface { get; } = questionInterface;

    public ICommetInterface CommetInterface { get; } = commetInterface;

    public ISavedInterface SavedInterface { get; } = savedInterface;

    public ITag TagInterface { get; } = tag;

    public void Dispose()
         => GC.SuppressFinalize(this);

    public async Task SaveAsync()
            => await _dbContext.SaveChangesAsync();
}
