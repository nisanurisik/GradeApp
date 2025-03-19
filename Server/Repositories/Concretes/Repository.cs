using Microsoft.EntityFrameworkCore;
using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class Repository<T, TId> : IRepository<T, TId> where T : Entity<TId>
  {
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context, DbSet<T> dbSet)
    {
      _context = context;
      _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
      var entities = await _dbSet.ToListAsync();
      return entities;
    }

    public async Task<T> GetByIdAsync(TId id)
    {
      var entity = await _dbSet.FindAsync(id);

      if (entity is null)
      {
        throw new Exception($"Id : {id} is not found!");
      }

      return entity;
    }

    public async Task AddAsync(T entity)
    {
      await _dbSet.AddAsync(entity);
      await SaveAsync();
    }

    public async Task UpdateAsync(T entity)
    {
      var updateEntity = await GetByIdAsync(entity.Id);
      _dbSet.Update(updateEntity);
      await SaveAsync();
    }

    public async Task DeleteAsync(TId id)
    {
      var deleteEntity = await GetByIdAsync(id);
      _dbSet.Remove(deleteEntity);
      await SaveAsync();
    }

    public async Task SaveAsync()
    {
      await _context.SaveChangesAsync();
    }
  }
}