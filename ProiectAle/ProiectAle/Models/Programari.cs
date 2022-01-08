using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace ProiectAle.Models
{
   public class Programari
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Parere { get; set; }
        public DateTime Date { get; set; }
    }
}
