using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class BaseRepository<T> where T : Base
    {
        public virtual void Create(T model)
        {
            using (var context = new EstoqueContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual List<T> Read()
        {
            List<T> lista = new List<T>();

            using (var context = new EstoqueContext())
            {
                lista = context.Set<T>().ToList();
            }
            return lista;
        }
        public virtual T Read(int id)
        {
            T model = Activator.CreateInstance<T>();

            using (var context = new EstoqueContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public virtual void Update(T model)
        {
            using (var context = new EstoqueContext())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public virtual void Delete(int id)
        {
            using (var context = new EstoqueContext())
            {
                context.Entry<T>(this.Read(id)).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
