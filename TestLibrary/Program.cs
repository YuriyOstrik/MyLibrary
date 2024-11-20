using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;


namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            // Тестирование методов с типом void
            myClass.PrintMessage("Hello, World!");
            myClass.PrintDate();
            // Тестирование методов с возвращаемыми значениями
            int sum = myClass.Add(5, 3); string greeting = myClass.GetGreeting("Alice"); 
            bool isEven = myClass.IsEven(4); 
            Console.WriteLine($"Сумма: {sum}"); 
            Console.WriteLine(greeting); 
            Console.WriteLine($"Четно ли 4? {isEven}");
        }
    }
}
