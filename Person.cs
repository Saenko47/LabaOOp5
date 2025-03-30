using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP5
{
    internal class Person
    {
        private string name;
        private string lastName;
        private DateTime birthdate;
        public Person()
        {
            this.name = "NoName";
            this.lastName = "NoLastName";
            this.birthdate = DateTime.Now;
        }
        public Person(string name, string lastName, DateTime birthdate)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthdate = birthdate;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public DateTime Birthdate
        {
            get { return this.birthdate; }
            set { this.birthdate = value; }
        }
        public int BirthYear
        {
            get { return this.birthdate.Year; }
            set { this.birthdate = new DateTime(value, this.birthdate.Month, this.birthdate.Day); }
        }
        public  override string ToString()
        {
            return Name + " " + LastName +" "+ "Date of birth:" + birthdate;
        }
        public virtual string ToShortString()
        {
            return $"{Name} {lastName}";
        }
        }
}
