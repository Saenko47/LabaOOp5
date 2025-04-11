using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabaOOP5
{
    internal class Article
    {
        const string pattern = @"^([A-Z][a-z]+)([\sA-Za-z])+$";
        public Person person;
        public string articleName;
        public double score;
        public Article()
        {
            this.person = new Person("No name", "No lastName", DateTime.Now);
            this.articleName = "No name";
            this.score = 0.0;
        }
        public Article(Person person, string articleName, double score)
        {
            this.person = person;
            this.articleName = Regex.IsMatch(articleName, pattern) ? articleName : throw new Exception("Wrong artricle name format string");
            this.score = score;
        }
        public Person Person
        {
            get { return this.person; }
            set { this.person = value; }

        }
        public string ArticleName
        {
            get { return this.articleName; }
            set
            {
                if (value != String.Empty && Regex.IsMatch(value, pattern)) this.articleName = value;
                else throw new Exception("Wrong article name format string");
            }
        }
        public double Score
        {
            get { return this.score; }
            set { if (value > 0) this.score = value;
                else throw new Exception("Value is such numbers");
            }
        }
        public override string ToString() {
            return $"{person} {articleName} {score:F1}";
        }
        
    }
}
