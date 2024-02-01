namespace Infrastructure.Interface;

public  interface IRepositorty<TEntity> where TEntity : BaseEntity
{
    Task<IQueryable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
}
