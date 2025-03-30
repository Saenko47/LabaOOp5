using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP5
{
    internal class Article
    {
        public Person person;
        public string articleName;
        public double score;
        public Article()
        {
            this.person = new Person("No name", "No lastName", DateTime.Now);
            this.articleName = "No article name";
            this.score = 0.0;
        }
        public Article(Person person, string articleName, double score)
        {
            this.person = person;
            this.articleName = articleName;
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
            set { this.articleName = value; }
        }
        public double Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
        public override string ToString() { 
        return person + " " + articleName + " " + score;
        }
        
    }
}
