using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOOP5.Program;

namespace LabaOOP5
{
    internal class Magazine
    {
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
            this.name = name;
            this.frequency = frequency;
            this.dateOfPublishing = dateOfPublishing;
            this.circulation = circulation;
            this.articles = articles ?? new Article[0];
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Frequency Frequency
        {
            get { return this.frequency; }
            set { this.frequency = value; }
        }
        public DateTime DateOfPublishing
        {
            get { return this.dateOfPublishing; }
            set { this.dateOfPublishing = value; }
        }
        public int Circulation
        {
            get { return this.circulation; }
            set { this.circulation = value; }
        }
        public Article[] Articles
        {
            get { return this.articles; }
            set { this.articles = value ?? new Article[0]; }
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
                articlelist.Append(articles[k].ToString()).Append(";");
            }
            return $"Magazine: {name}, Frequency: {Frequency}, Release Date: {dateOfPublishing:yyyy-MM-dd}, Circulation: {Circulation}, Avg Score: {avgscore:F1}, articles:{articlelist}";
        }
        public string ToShortString()
        {
            return $"Magazine: {name}, Frequency: {frequency}, Release Date: {dateOfPublishing:yyyy-MM-dd}, Circulation: {circulation}, Avg Score: {avgscore:F1}";

        }
    }
}
