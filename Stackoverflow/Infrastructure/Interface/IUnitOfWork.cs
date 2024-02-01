namespace Infrastructure.Interface;

public interface IUnitOfWork : IDisposable
{
    IAnswerInterface AnswerInterface { get; }
    IQuestionTagInterface QuestionTagInterface { get; }
    IQuestionInterface QuestionInterface { get; }
    ICommetInterface CommetInterface { get; }
    ISavedInterface SavedInterface { get; }
    ITag TagInterface { get; }

    Task SaveAsync();
}
