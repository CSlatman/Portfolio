using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDatabaseTest
{
    public class Student
    {
        private int nummer;
        private string voornaam;
        private string achternaam;

        public int Nummer
        {
            get { return nummer; }

        }
        
        public string Voornaam
        {
            set { voornaam = value; }
            get { return voornaam; }
        }

        public string Achternaam
        {
            set { achternaam = value; }
            get { return achternaam; }
        }

        public Student(int nummer, string voornaam, string achternaam)
        {
            this.nummer = nummer;
            this.voornaam = voornaam;
            this.achternaam=achternaam;
        }


    }
}
