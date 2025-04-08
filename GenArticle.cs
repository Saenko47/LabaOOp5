using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP5
{
    internal class GenArticle
    {
        static Random rnd = new Random();
        private static string[] articleNames = new string[]
{
    "Understanding Artificial Intelligence",
    "The Future of Quantum Computing",
    "Exploring the Depths of Space",
    "Climate Change and Global Impact",
    "The Rise of Renewable Energy",
    "Cybersecurity in the Modern World",
    "Genetic Engineering: Risks and Rewards",
    "The Psychology of Decision Making",
    "Blockchain Beyond Cryptocurrency",
    "The Art of Effective Communication",
    "Machine Learning in Healthcare",
    "Virtual Reality: Gaming and Beyond",
    "The Ethics of AI Development",
    "Big Data and Predictive Analytics",
    "Biotechnology and Human Life",
    "The Science of Sleep",
    "History of the Internet",
    "The Role of Technology in Education",
    "Renewable vs. Nonrenewable Energy",
    "Social Media and Mental Health"
};
       public Article[] GenerateArticles(Person[] persons)
        {
            Article[] articles = new Article[persons.Length]; 
for(int k = 0;k<persons.Length; ++k)
            {
                articles[k] = new Article(persons[k], articleNames[rnd.Next(0, articleNames.Length)], rnd.NextDouble()*5);
            }
return articles;
        }

    }
}
