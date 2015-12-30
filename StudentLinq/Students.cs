using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinq
{
    class Students
    {
        string firstName = "";
        string lastName = "";
        List<int> grades = new List<int>();

        /*
        *
        *Create generic constructor to intailize students
        *
        */
        public Students()
        {

        }

        /*
        *
        *Create consturctor to initlize students with a first name, last name
        *@param firstName-The first name of the student. String type.
        *@param lastName-The last name of the student. String type.
        */
        public Students(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        /*
        *
        *Creates constructor to initalize student with a first name, last name, and a grade
        *@param firstName-The first name of the student. String type.
        *@param lastName-The last name of the student. String type.
        *@param grade-A grade for the student. Gets added to the list of grades. Integer type
        *
        */
        public Students(string firstName, string lastName, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            grades.Add(grade);
        }

        /*
        *Sets the firstName of the student
        *@param firstName-The first name of the student. String type
        */
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        /*
        *Gets the students firstName
        *
        */
        public string getFirstName()
        {
            return firstName;
        }

        /*
        *Sets the lastName of the student
        *@param lastName-The last name of the student. String type
        */
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        /*
        *Gets the students lastName
        *
        */
        public string getLastName()
        {
            return lastName;
        }

    }
}
