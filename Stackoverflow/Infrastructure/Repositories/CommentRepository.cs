
namespace Infrastructure.Repositories;

public class CommentRepository(ApplicationDbContext dbContext) : Repository<Comment>(dbContext), ICommetInterface
{
}
