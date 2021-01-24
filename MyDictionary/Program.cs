using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> students = new MyDictionary<string>();
            students.Add("Can");
            students.Add("Engin");

            Console.WriteLine("Öğrenci Sayısı: "+students.Length);

            Loop(students);
            
            students.Add("İrem");
            Console.WriteLine("***************");
            Console.WriteLine("Öğrenci Sayısı: " + students.Length);
            Loop(students);
            
        }

        private static void Loop(MyDictionary<string> students)
        {
            foreach (var student in students.Student)
            {
                Console.WriteLine(student);
            }
        }
    }
}
