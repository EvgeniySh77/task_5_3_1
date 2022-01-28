using System;

namespace task_5_3_1
{
    class Program
    {
        static void Main()
        {
            int age;
            Console.Write("Введите свой возраст: ");
            age = int.Parse(Console.ReadLine());

            ChangeAge(age);
            Console.WriteLine(age);

            Console.ReadKey();
        }
        
        static int ChangeAge(int age)
        {
            age = 27;
            return age;
        }
    }
}
