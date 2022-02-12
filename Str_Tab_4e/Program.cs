using System;

namespace Str_Tab_4e
{
    using System;
        class Program
        {
        struct Person
        {
            public string firstName, lastName, yearsOfEducation, letterOfClass;
            public void Print()
            {
                Console.WriteLine($"Имя: {firstName} {lastName} Года обучения: {yearsOfEducation} {letterOfClass}");
            }

        }
        static void Main(string[] args)
        {
            int n = 25;
            Random rnd = new Random();
            string[] names = new string[n];
            string[] surnames = new string[n];
            names[0] = "Семен";
            names[1] = "Даниил";
            names[2] = "Артем";
            names[3] = "Сергей";
            names[4] = "Иван";
            surnames[0] = "Иванов";
            surnames[1] = "Авдеев";
            surnames[2] = "Романов";
            surnames[3] = "Тугаринов";
            surnames[4] = "Шувалов";
            Person[] students = new Person[n];
            int plusator8 = 0;
            int plusator10 = 0;

            for (int i = 0; i < n; i++)
            {
                students[i].firstName = names[rnd.Next(0, 5)];
                students[i].lastName = surnames[rnd.Next(0, 5)];
                students[i].yearsOfEducation = rnd.Next(1, 12).ToString();
                if (students[i].yearsOfEducation == "8")
                {
                    plusator8++;
                }
                if (students[i].yearsOfEducation == "10")
                {
                    plusator10++;
                }
                students[i].letterOfClass = "a";
                students[i].Print();
            }
            if (plusator8 > plusator10)
            {
                Console.WriteLine($"В восьмом классе на {plusator8-plusator10} большей людей");
            }
            if (plusator8 < plusator10)
            {
                Console.WriteLine($"В восьмом классе на {plusator10-plusator8} меньше людей");
            }
            if (plusator8 == plusator10)
            {
                Console.WriteLine($"В восьмом и десятом классе одинакова людей");
            }
        }
    }
    }
