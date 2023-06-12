using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace JsonDatabaseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonManager jsonManager = new JsonManager();
            List<Student> studenten = jsonManager.InladenStudenten();
            List<Klas> klassen = jsonManager.InladenKassen();

            Klas OvPS1 = new Klas("OvPS1");
            OvPS1.Locatie = "Online";

            Console.WriteLine("De klas is: " + OvPS1.Code + " en de locatie is: " + OvPS1.Locatie);

            
            for (int i = 0; i < 5; i++)
            {
                Student nieuwStudent = MaakNieuweStudent();
                OvPS1.AddStudent(nieuwStudent);
            }

            Console.WriteLine("De klas heeft nu de volgende studenten:");
            foreach (Student student in OvPS1.Studenten)
            {
                Console.WriteLine(student.Voornaam + " " + student.Achternaam + " {" + student.Nummer.ToString() + ")"); 
            }


            klassen.Add(OvPS1);
            jsonManager.OpslaaanKlassen(klassen);

            Console.ReadLine();

            // publid static Student MaakNieuweStudent


        }

        public static Student MaakNieuweStudent()
        {
            Student nieuweStudent = null;

            Console.WriteLine("Geef de voornaam van de student: ");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Geef de achternaam van de student: ");
            string achternaam = Console.ReadLine();

            int studentNr = -1;
            Console.WriteLine("Geef het studentnummer: ");
            if (!int.TryParse(Console.ReadLine(), out studentNr))
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                nieuweStudent = new Student(studentNr, voornaam, achternaam);
            }
            return nieuweStudent;
            
        }

    }
}