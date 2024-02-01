
namespace Infrastructure.Repositories;

public class QuestionRepository(ApplicationDbContext dbContext) : Repository<Question>(dbContext), IQuestionInterface
{
}
