using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var omit = char.Parse(Console.ReadLine());
            var result = new List<string>();

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        result.Add(i.ToString() + j.ToString() + k.ToString());
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result.Where(x => !x.Contains(omit))));

        }
    }
}