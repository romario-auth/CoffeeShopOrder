﻿using CoffeeShopOrder.Application.Context;
using CoffeeShopOrder.Domain.Interfaces;
using CoffeeShopOrder.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopOrder.Application.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            entity.SetCreate();
            _context.Add(entity);
        }
        public void Update(T entity)
        {
            entity.SetUpdated();
            _context.Update(entity);
        }

        public void Delete(T entity)
        {
            entity.SetUpdated();
            _context.Remove(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }
    }
}
