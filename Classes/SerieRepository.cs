using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIOCrud.Interface;

namespace DIOCrud.Classes
{
    class SerieRepository : IRepository<Serie>
    {
        private List<Serie> myList = new List<Serie>();

        public List<Serie> ReturnList()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Serie obj)
        {
            throw new NotImplementedException();
        }

        public int NextId()
        {
            throw new NotImplementedException();
        }

        public Serie ReturnById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Serie obj)
        {
            throw new NotImplementedException();
        }
    }
}
