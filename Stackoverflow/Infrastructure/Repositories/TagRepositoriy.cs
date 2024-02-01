
namespace Infrastructure.Repositories;

public class TagRepositoriy(ApplicationDbContext dbContext) : Repository<Tag>(dbContext), ITag
{
}
