using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDatabaseTest
{
    internal class Klas
    {
        private string code;
        private string naam;
        private string locatie;
        private List<Student> studenten;

        public string Code
        {
            get { return code; }
        }

        public string Naam
        { 
            get { return naam; } 
        }

        public string Locatie
        { 
            set { locatie= value; }
            get { return locatie; }
        }

        public List<Student> Studenten
        {
            get { return studenten; }
        }
        public Klas(string code)
        {
            this.code = code;
            this.studenten = new List<Student>();
        }

        public void AddStudent(Student student)
        { 
            Studenten.Add(student);
        }


    }
}
