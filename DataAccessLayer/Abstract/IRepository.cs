using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<Entity>
    {
        List<Entity> List();
        void Add(Entity entity);
        
        Entity Get (Expression<Func<Entity, bool>> filter);
        void Update(Entity entity);
        void Delete(Entity entity);

        List<Entity> List(Expression<Func<Entity, bool>> filter);
        
    }
}
