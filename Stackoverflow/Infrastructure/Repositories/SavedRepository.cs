
namespace Infrastructure.Repositories;

public class SavedRepository(ApplicationDbContext dbContext) : Repository<Saved>(dbContext), ISavedInterface
{
}
