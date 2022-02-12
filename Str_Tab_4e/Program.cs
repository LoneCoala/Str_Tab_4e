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
                Console.WriteLine($"Имя: {firstName} {lastName} Года обучения: {yearsOfEducation}{letterOfClass}");
            }

        }
        static void Main(string[] args)
        {
            int n = 5;
            Random rnd = new Random();
            string[] names = new string[n];
            string[] surnames = new string[n];

            int plusator8 = 0;
            int plusator10 = 0;

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

            Console.Write("Введите число учеников:");
            string userInputN = Console.ReadLine();

            n = untilNisNotANumber(userInputN);

            Person[] students = new Person[n];

            for (int i = 0; i < n; i++)
            {
                int randName = rnd.Next(0, 4);
                int randSurname = rnd.Next(0, 4);

                students[i].firstName = names[randName];
                students[i].lastName = surnames[randSurname];
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

            isEightMoreThanTenthStudents(plusator8,plusator10);


            void isEightMoreThanTenthStudents(int plusator8, int plusator10)
            {
                if (plusator8 > plusator10)
                {
                    Console.WriteLine($"В восьмом классе на {plusator8 - plusator10} большей учеников");
                }
                if (plusator8 < plusator10)
                {
                    Console.WriteLine($"В восьмом классе на {plusator10 - plusator8} меньше учеников");
                }
                if (plusator8 == plusator10)
                {
                    Console.WriteLine($"В восьмом и десятом классе одинаковое кол-во учеников");
                }
            }

            int untilNisNotANumber(string userInputN)
            {
                int number;
                while (!int.TryParse(userInputN, out number) || (number <= 0))
                {
                    Console.WriteLine($"Ошибка!Введено '{userInputN}' вместо положительного числа, попробуйте снова");
                    userInputN = Console.ReadLine();
                }
                return number;
            }
        }
    }
}
