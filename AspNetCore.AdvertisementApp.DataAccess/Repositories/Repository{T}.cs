using AspNetCore.AdvertisementApp.Common.Enums;
using AspNetCore.AdvertisementApp.DataAccess.Contexts;
using AspNetCore.AdvertisementApp.DataAccess.Interfaces;
using AspNetCore.AdvertisementApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AspNetCore.AdvertisementApp.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        private DbSet<T> Table { get => _context.Set<T>(); }

        public async Task<List<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await Table.Where(filter).AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC ? await Table.OrderBy(selector).AsNoTracking().ToListAsync() 
                : await Table.OrderByDescending(selector).AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC ? await Table.Where(filter).OrderBy(selector).AsNoTracking().ToListAsync()
                : await Table.Where(filter).OrderByDescending(selector).AsNoTracking().ToListAsync();
        }

        public async Task<T> FindAsync(object id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T,bool>> filter, bool asNoTracking = false)
        {
            return asNoTracking == true ? await Table.AsNoTracking().SingleOrDefaultAsync(filter) :
                await Table.SingleOrDefaultAsync(filter);
        }

        public async Task CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public IQueryable<T> GetQuery()
        {
            return Table.AsQueryable();
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
        }        

        public void Update(T entity, T unchanged)
        {
            _context.Entry(unchanged).CurrentValues.SetValues(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await Table.AnyAsync(filter);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> filter)
        {
            return await Table.CountAsync(filter);
        }
    }
}
