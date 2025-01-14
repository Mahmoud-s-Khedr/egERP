using System;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data.Repos;


public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class
{
    private readonly ApplicationDbContext db;
    private DbSet<TEntity> dbset;

    public GenericRepository(ApplicationDbContext _db)
    {
        this.db = _db;
        this.dbset = db.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await dbset.ToListAsync();
    }

    public async Task<TEntity?> GetById(int id)
    {
        return await dbset.FindAsync(id);
    }

    public async Task Add(TEntity entity)
    {
        await dbset.AddAsync(entity);
    }

    public async Task Update(TEntity entity) //Depend on ORM Tracker
    {
        dbset.Entry(entity).State = EntityState.Modified;
        await db.SaveChangesAsync();
    }

    public async Task Delete(TEntity entity)
    {
        dbset.Remove(entity);
        await db.SaveChangesAsync();
    }
    public async Task Delete(int id)
    {
        TEntity? entity = await GetById(id);
        
        if (entity is not null)
            await Delete(entity);
        else
            throw new Exception("Not Found");
    }
}