using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIOCrud;

namespace DIOCrud.Classes
{
    public class Serie : EntityBase
    {
        // props
        private string title { get; set; }
        private string description { get; set; }
        private int year { get; set; }
        private Genre genre { get; set; }
        private bool removed { get; set; }

        //methods
        public Serie(int id, string title, string description, int year, Genre genre) 
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.year = year;
            this.genre = genre;
            removed = false;
        }

        public int GetId() { return id; }

        public string GetTitle() { return title; }

        public bool GetRemove() { return removed;  }

        public void RemoveSerie() { removed = true; }

        public void UnremoveSerie() { removed = false; }

        public override string ToString()
        {
            string toReturn = "Titulo: " + title + Environment.NewLine;
            toReturn += "Genero: " + genre + Environment.NewLine;
            toReturn += "Descricao: " + description + Environment.NewLine;
            toReturn += "Ano: " + year.ToString();
            return toReturn;
        }
    }
}
