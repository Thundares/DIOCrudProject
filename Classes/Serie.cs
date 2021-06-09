using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIOCrud.Enum;

namespace DIOCrud.Classes
{
    public class Serie : EntityBase
    {
        // props
        private string title { get; set; }
        private string description { get; set; }
        private int year { get; set; }
        private Genre genre { get; set; }

        //methods
        public Serie(int id, string title, string description, int year, Genre genre) 
        {
            this.Id = id;
            this.title = title;
            this.description = description;
            this.year = year;
            this.genre = genre;
        }

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
