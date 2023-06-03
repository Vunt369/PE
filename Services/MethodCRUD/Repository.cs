using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.MethodCRUD
{
    public class Repository<T> where T : class
    {
        BankAccountTypeContext _context;
        DbSet<T> _dbSet;

        public Repository()
        {
            _context = new BankAccountTypeContext();
            _dbSet = _context.Set<T>();
        }
        public List<T> getAll()
        {
            return _dbSet.ToList();
        }
        public void add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void remove(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
       
    }
}
