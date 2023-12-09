using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Backjoon
{
    internal class _5052
    {
        public void Program()
        {
            int cnt = int.Parse(Console.ReadLine());
            int maxCnt;
            bool trigger;
            string[] numbers;

            for (int i = 0; i < cnt; i++)
            {
                trigger = false;
                numbers = new string[maxCnt = int.Parse(Console.ReadLine())];

                for (int j = 0; j < maxCnt; j++)
                {
                    numbers[j] = Console.ReadLine();
                }

                Array.Sort(numbers);

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    Console.WriteLine("j " + numbers[j]); 
                    Console.WriteLine("j + 1 "+numbers[j + 1]); 
                    
                    if (numbers[j + 1].StartsWith(numbers[j]))
                    {
                        trigger = true;
                        // break;
                        Console.WriteLine("Y");
                    }
                    
                    Console.WriteLine();
                }
                Console.WriteLine(trigger ? "NO" : "YES");
            }
        }
    }
}
