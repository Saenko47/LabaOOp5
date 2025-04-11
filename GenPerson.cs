using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LabaOOP5
{
    internal class GenPerson
    {
        static Random rnd = new Random();
        
        private static string[] names = new string[]
        {
        "Александр", "Максим", "Дмитрий", "Артем", "Иван",
    "Михаил", "Кирилл", "Андрей", "Егор", "Сергей",
    "Никита", "Тимофей", "Алексей", "Владимир", "Олег",
    "Илья", "Роман", "Павел", "Юрий", "Борис",
    "Виктор", "Степан", "Григорий", "Фёдор", "Константин"
        };
        private static string[] lastnames = new string[] {
            "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов",
    "Попов", "Васильев", "Новиков", "Фёдоров", "Морозов",
    "Волков", "Алексеев", "Лебедев", "Семенов", "Егоров",
    "Павлов", "Козлов", "Степанов", "Николаев", "Орлов",
    "Макаров", "Захаров", "Соловьёв", "Белов", "Комаров"
        };
        public Person[] GeneratePerson(int n)
        {
            Person[] person = new Person[n];
            for (int k = 0;k<n; ++k)
            {
                int year = rnd.Next(1950, 2025);
                int month = rnd.Next(1, 13);
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int day = rnd.Next(1, daysInMonth + 1);
               
                DateTime birthDate = new DateTime(year, month, day);
                person[k] = new Person(names[rnd.Next(0, names.Length)], lastnames[rnd.Next(0, lastnames.Length)],birthDate);


            }
            return person;
        }
    }
}
