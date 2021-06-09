using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOCrud.Interface
{
    interface IRepository<T>
    {
        List<T> ReturnList();
        T ReturnById(int id);
        void Insert(T obj);
        void Delete(int id);
        void Update(int id, T obj);
        int NextId();
    }
}
