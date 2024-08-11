using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLvl2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу которая будет повторятся");
            string userInput = Console.ReadLine();
            Console.WriteLine("Сколько раз необходимо повторить фразу?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(userInput);
            }
        }
    }
}
