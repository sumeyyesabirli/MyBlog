using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<Entity> : IRepository<Entity> where Entity : class
    {
        Context context= new Context();
        DbSet<Entity> _object;
        public GenericRepository()
        {
            _object = context.Set<Entity>();
        }
        public void Add(Entity entity)
        {
            var addEntity = context.Entry(entity);
            addEntity.State= EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Entity entity)
        {
            var deleteEntity = context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;
            context.SaveChanges();

        }

        public Entity Get(Expression<Func<Entity, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<Entity> List()
        {
            return _object.ToList();
        }

        public List<Entity> List(Expression<Func<Entity, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(Entity entity)
        {
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
