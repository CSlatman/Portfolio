using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Admin_Portfolio
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName 
        { 
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
