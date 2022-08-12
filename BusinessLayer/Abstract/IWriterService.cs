using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void WriteryAdd(Writer writer);
        void CategoryDelete(Writer writer);
        void CategoryUpdate(Writer writer);
        Writer GetByID(int id);

    }
}
