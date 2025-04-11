using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static LabaOOP5.Program;

namespace LabaOOP5
{
    internal class Magazine
    {
        const string pattern = @"^([A-Z][a-z]+)([\sA-Za-z])+$";
        const string datepattern = @"^\d{4},\d{2},\d{2}$";
        private string name;
        private Frequency frequency;
        private DateTime dateOfPublishing;
        private int circulation;
        private Article[] articles;
        public Magazine()
        {
            this.name = "NoName";
            this.frequency = Frequency.Monthly;
            this.dateOfPublishing = DateTime.Now;
            this.circulation = 0;
            this.articles = new Article[0];
        }
        public Magazine(string name, Frequency frequency, DateTime dateOfPublishing, int circulation, Article[] articles)
        {
            this.name = name != String.Empty && Regex.IsMatch(name, pattern) ? name : throw new Exception("Wrong name for magazine");
            this.frequency = frequency;
            this.dateOfPublishing = (Regex.IsMatch(dateOfPublishing.ToString("yyyy,MM,dd"), datepattern) ? dateOfPublishing : throw new Exception("Invalid dateOfPublishing format."));
            this.circulation = (circulation>0)?circulation:21;
            this.articles = articles ?? new Article[0];
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != String.Empty && Regex.IsMatch(value, pattern)) this.name = value;
                else throw new Exception("Wrong name format string");
            }
        }
        public Frequency Frequency
        {
            get { return this.frequency; }
            set { this.frequency = value; }
        }
        public DateTime DateOfPublishing
        {
            get { return this.dateOfPublishing; }
            set
            {
                if (Regex.IsMatch(value.ToString("yyyy-MM-dd"), datepattern))
                {
                    this.dateOfPublishing = value;
                }
                else
                {
                    throw new Exception("Invalid dateOfPublishing format.");
                }
            }
        }
        public int Circulation
        {
            get { return this.circulation; }
            set
            {
                if (value > 0) this.circulation = value;
                else throw new Exception("Value is such numbers");
            }
        }
        public Article[] Articles
        {
            get { return this.articles; }
            set { this.articles = value ?? new Article[0]; }
        }
        public Article this[int index]{
            get { return this.articles[index]; }
            set { this.articles[index] = value; }
            }
        public double AvarageScore()
        {
            double avarage = 0;
            for (int k = 0; k < articles.Length; ++k)
            {
                avarage += articles[k].Score;
            }
            return avarage / (articles.Length);
        }
        public double avgscore => AvarageScore();
        public void AddArticle(params Article[] newArticles)
        {

            if (newArticles == null || newArticles.Length == 0) return;
            int capacity = articles.Length + newArticles.Length;
            Article[] updatedArticles = new Article[capacity];
            for (int i = 0; i < articles.Length; i++)
            {
                updatedArticles[i] = articles[i];
            }
            for (int i = 0; i < newArticles.Length; i++)
            {
                updatedArticles[articles.Length + i] = newArticles[i];
            }
            articles = updatedArticles;


        }
        public override string ToString()
        {
            StringBuilder articlelist = new StringBuilder();
            for (int k = 0; k < articles.Length; ++k)
            {
                articlelist.Append(articles[k].ToString()).Append(";\n");
            }
            return $"Magazine: {name}, Frequency: {Frequency}, Release Date: {dateOfPublishing:yyyy-MM-dd}, Circulation: {Circulation}, Avg Score: {avgscore:F1}, articles:\n{articlelist}";
        }
        public string ToShortString()
        {
            return $"Magazine: {name}, Frequency: {frequency}, Release Date: {dateOfPublishing:yyyy-MM-dd}, Circulation: {circulation}, Avg Score: {avgscore:F1}";

        }
    }
}
