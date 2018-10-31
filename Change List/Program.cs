using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultList = new List<int>();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                int index = 0;
                int anotherInteger = 0;

                switch (command[0])
                {
                    case "Delete":
                        var element = int.Parse(command[1]);
                        for (int i = 0; i < integers.Count; i++)
                        {
                            integers.Remove(element);
                        }
                        break;
                    case "Insert":
                        index = int.Parse(command[2]);
                        anotherInteger = int.Parse(command[1]);
                        integers.Insert(index, anotherInteger);
                        break;
                    case "Odd":
                        for (int i = 0; i < integers.Count; i++)
                        {
                            if (Math.Abs(integers[i]) % 2 == 1)
                            {
                                resultList.Add(integers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", resultList));
                        break;
                    case "Even":
                        for (int i = 0; i < integers.Count; i++)
                        {
                            if (Math.Abs(integers[i]) % 2 == 0)
                            {
                                resultList.Add(integers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", resultList));
                        break;
                }

                if (command[0] == "Even" || command[0] == "Odd")
                {
                    break;
                }
            }
        }
    }
}
