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
            return myList;
        }

        public void Delete(int id)
        {
            myList[id].RemoveSerie();
        }

        public void Insert(Serie obj)
        {
            myList.Add(obj);
        }

        public int NextId()
        {
            return myList.Count;
        }

        public Serie ReturnById(int id)
        {
            return myList[id];
        }

        public void Update(int id, Serie obj)
        {
            myList[id] = obj;
        }
    }
}
