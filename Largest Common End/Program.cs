using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] secondString = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int rightCount = 0;
            int leftCount = 0;

            while (firstString.Length > rightCount && secondString.Length > rightCount)
            {
                if (firstString[firstString.Length - rightCount - 1] == secondString[secondString.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else break;
            }

            while (firstString.Length > leftCount && secondString.Length > leftCount)
            {
                if (firstString[leftCount] == secondString[leftCount])
                {
                    leftCount++;
                }
                else break;
            }

            if (rightCount > leftCount)
            {
                Console.WriteLine(rightCount);
            }
            else Console.WriteLine(leftCount);
        }
    }
}
