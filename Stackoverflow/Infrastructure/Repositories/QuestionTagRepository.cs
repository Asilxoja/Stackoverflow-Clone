
namespace Infrastructure.Repositories;

public class QuestionTagRepository(ApplicationDbContext dbContext) : Repository<QuestionTag>(dbContext), IQuestionTagInterface
{
}
