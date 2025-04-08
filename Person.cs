using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LabaOOP5
{
    internal class Person
    {
        const string pattern = @"^[А-Яа-яЁё]+$";
        const string datepattern = @"yyyy-MM-dd";
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
            this.name = Regex.IsMatch(name, pattern)?name: throw new Exception("Wrong name format string") ;
            this.lastName = lastName;
            this.birthdate = birthdate;
        }
        public string Name
        {
            get { return this.name; }
            set {if (value != String.Empty&&Regex.IsMatch(value,pattern)) this.name = value;
                else throw new Exception("Wrong name format string");
            }

        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value != String.Empty && Regex.IsMatch(value, pattern)) this.lastName = value;
                else throw new Exception("Empty string");
            }
        }
        public DateTime Birthdate
        {
            get { return this.birthdate; }
            set {
                if (Regex.IsMatch(value.ToString("yyyy-MM-dd"), datepattern))
                {
                    this.birthdate = value;
                }
                else
                {
                    throw new Exception("Invalid birthdate format.");
                }
            }
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
