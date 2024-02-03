namespace Application.Common.Helpers;

public static class Validator
{
    public static bool IsExist(this Question question, IEnumerable<Question> questions)
        => questions.Any(a => a.Title == question.Title);
}
