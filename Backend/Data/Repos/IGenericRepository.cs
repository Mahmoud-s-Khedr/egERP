using System;

namespace Backend.Data.Repos;

public interface IGenericRepository<TEntity>
    where TEntity : class
{
    public Task<IEnumerable<TEntity>> GetAll();
    public Task<TEntity?> GetById(int id);
    public Task Add(TEntity entity);
    public Task Update(TEntity entity);
    public Task Delete(TEntity entity);
    public Task Delete(int id);
}
