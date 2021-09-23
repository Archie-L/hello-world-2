using System;
using System.Collections.Generic;

namespace Hello_Word_2
{
    class Program
    {
        static int age = 16;
        static float age2 = 16.2f;
        static string word = "My age is ", word2 = "My exact age is ", word3 = "My grade is ";
        static char grade = 'A';

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            List<string> list2 = new List<string>();
            list2.Add("test1");
            list2.Add("test2");
            list2.Add("test3");
            list2.Add("test4");
            list2.Add("test5");

            foreach (string i in list2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(word + age);
            Console.WriteLine();
            Console.WriteLine(word2 + age2);
            Console.WriteLine();
            Console.WriteLine(word3 + grade);

            Console.ReadKey();
        }

    }
}
