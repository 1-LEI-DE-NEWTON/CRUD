﻿using CRUD.Domain.Entities;
using CRUD.Infra.Context;
using CRUD.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace CRUD.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<T> Create(T obj)
        {
            _context.Set<T>().Add(obj);
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<T> Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }

        public async Task<T> Remove(long id)
        {
            var obj = await Get(id);
            if (obj == null)
                return null;

            _context.Set<T>().Remove(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<T> Get(long id)
        {
            var obj = await _context.Set<T>()
                .AsNoTracking()
                .Where(x => x.Id == id)
                .ToListAsync();
            return obj.FirstOrDefault();
        }

        public virtual async Task<List<T>> Get()
        {
            return await _context.Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
