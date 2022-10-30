using FoodCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FoodCore.Repository
{
    public class GenericRepository<T> where T : class, new()
    {
        Context _context = new Context();
        public List<T> GetAllGeneric()
        {
            return _context.Set<T>().ToList();
        }
        public List<T> GetAllGeneric(string category)
        {
            return _context.Set<T>().Include(category).ToList();
        }

        public T GetByIdGeneric(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void CreateGeneric(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }
        public void UpdateGeneric(T t)
        {
            _context.Set<T>().Update(t);
            _context.SaveChanges();
        }
        public void DeleteGeneric(int id)
        {
            var deleted = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(deleted);
            _context.SaveChanges();
        }
    }
}
