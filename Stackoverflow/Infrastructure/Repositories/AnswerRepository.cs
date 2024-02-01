global using Infrastructure.Data;
global using Infrastructure.Interface;

namespace Infrastructure.Repositories;

public class AnswerRepository(ApplicationDbContext dbContext) : Repository<Answer>(dbContext), IAnswerInterface
{
}
