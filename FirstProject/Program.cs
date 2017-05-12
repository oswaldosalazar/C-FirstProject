using System;

namespace FirstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Xamarin University!");

            string name = "Judy";
            string city = "Phoenix";
            int age = 25;

            Console.WriteLine("My name is " + name + " and I live in " + city + " and I am " + age + " years old.");
            Console.WriteLine("My name is {0} and I live in {1} and I am {2} years old.", name, city, age);
        }
    }
}
