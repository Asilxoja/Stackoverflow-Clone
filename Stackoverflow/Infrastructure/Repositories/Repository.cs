using Domain;
using Infrastructure.Data;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<TEntity> : IRepositorty<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;
    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public async Task AddAsync(TEntity entity)
    {
        if (entity is null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        if (entity is null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public Task<IQueryable<TEntity>> GetAllAsync()
    {
        var list = _dbSet.AsNoTracking()
                        .AsQueryable();

        return Task.FromResult(list);
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(c => c.Id == id);

        return entity ?? throw new Exception($"GetByIdAsync entity not found for ID: {id}");
    }

    public async Task UpdateAsync(TEntity entity)
    {
        if (entity is null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}
