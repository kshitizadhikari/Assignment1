using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = {8, 7, 2, 5, 3, 1};
            int target1 = 10;
            int[] nums2 = { 5, 2, 6, 8, 1, 9 };
            int target2 = 12;


            void findPair(int[] arr, int target)
            {
                HashSet<int> newSet = new HashSet<int>();
                int flag = 0;

                foreach (int num in arr)
                {
                    int complement = target - num;

                    if (newSet.Contains(complement))
                    {
                        Console.WriteLine($"Pair Found: ({num}, {complement})");
                        flag = 1;
                        break;
                    }

                    newSet.Add(num);
                }

                if (flag == 0)
                {
                    Console.WriteLine("Pair Not Found");
                }
            }

            findPair(nums, target1);
            findPair(nums2, target2);

            Console.ReadKey();
        }

        
    }
}
