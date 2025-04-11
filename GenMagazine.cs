using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static LabaOOP5.Program;

namespace LabaOOP5
{
    internal class GenMagazine
    {
        static Random rnd = new Random();
        static GenArticle genArticle = new GenArticle();
        static GenPerson genPerson = new GenPerson();
        private static string[] magnames = new string[] {
    "Future Tech",
    "Science World",
    "Travel Discoveries",
    "Code Algorithms",
    "Modern Art",
    "Health Today",
    "Eco Life",
    "Business Insight",
    "History Uncovered",
    "Creative Minds",
    "Digital Trends",
    "Space Explorer"
};
       public Magazine[] GenerateMagazine(int k, int j)
    {
        Magazine [] magazines = new Magazine[k];
        for(int i = 0;i<k; ++i)
        {
                try
                {
                    Person[] persons = null;
                    try
                    {
                        persons = genPerson.GeneratePerson(j);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error generating persons at index {i}: {ex.Message}");
                        continue; 
                    }
                    Article[] articles = null;
                    try
                    {
                        articles = genArticle.GenerateArticles(persons);
                    }
                    catch (Exception ex) {
                        Console.WriteLine($"Error generating article at index {i}:{ex.Message}");
                        continue;
                    }
                    try
                    {
                        int year = rnd.Next(1950, 2025);
                        int month = rnd.Next(1, 13);
                        int daysInMonth = DateTime.DaysInMonth(year, month);
                        int day = rnd.Next(1, daysInMonth + 1);
                        DateTime birthDate = new DateTime(year, month, day);
                        magazines[i] = new Magazine(magnames[rnd.Next(0, magnames.Length)], (Frequency)rnd.Next(0, 3), birthDate, rnd.Next(1, 2448), articles);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Error generating magazine at index {i}:{ex.Message}");
                        continue;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Unexpexted error: {ex}");
                    continue;
                }
        }
        return magazines;
    }
       
    }
}
