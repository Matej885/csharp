using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int age = (15);
            Console.WriteLine(age);

            float pi = 3.14f;
            Console.WriteLine(pi);

            string name = ("Matej");
            Console.WriteLine(name);

            char pohlavie = 'M';
            Console.WriteLine(pohlavie);

            bool isAdult = false;
            Console.WriteLine(isAdult);
            */
            int a = 10;
            int b = 1;

            int sum = a + b;
            Console.WriteLine(sum);

            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine("Matej");

            int birthDay = 1;
            int birthMonth = 5;
            int birthYear = 2010;

            int birthsum = birthDay + birthMonth + birthYear;
            Console.WriteLine(birthsum);
            Console.WriteLine(birthsum * 10);
            Console.WriteLine((birthDay + birthMonth) * birthYear);
            Console.WriteLine(5f / 3f);
            string meno = ("Matej");
            Console.WriteLine(meno + birthYear);
            Console.WriteLine(meno + (birthMonth + birthYear));
            bool result = 6 != 6;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
