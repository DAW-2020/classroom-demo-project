using DAW.Data;
using DAW.Entities;
using DAW.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly ClassroomDbContext _context;
        protected readonly DbSet<T> _table;

        public GenericRepository(ClassroomDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Create(T entity)
        {
            entity.CreateTime = DateTime.UtcNow;
            entity.UpdatedTime = DateTime.UtcNow;
            _context.Set<T>().Add(entity);
        }

        public void CreateRange(List<T> entities)
        {
            entities.ForEach(x =>
            {
                x.CreateTime = DateTime.UtcNow;
                x.UpdatedTime = DateTime.UtcNow;
            });

            _table.AddRange(entities);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);
        }

        public void HardDelete(T entity)
        {
            _table.Remove(entity);
        }

        public T FindById(int id)
        {
            return _table.Find(id);
        }

        public List<T> GetAllActive()
        {
            return _table.Where(x => !x.IsDeleted).ToList();
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(T entity)
        {
            entity.UpdatedTime = DateTime.UtcNow;
            _table.Update(entity);
        }
    }
}
