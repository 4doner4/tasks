using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class TwoArrays
    {
        public static void TwoArraysTask()
        {
            /*
 Дано два массива
let array1 = [1,2,7,9,5]
let array2 = [4,6,8,3]
Напишите функцию, которая сортирует массивы, оставив в одном только четные числа, в другом не четные
 
 */

            int[] firstArray = { 1, 2, 7, 9, 5 };
            int[] secondArray = { 4, 6, 8, 3 };

            List<int> evenNumbers = new();
            List<int> oddNumbers = new();

            foreach (int item in secondArray.Concat(firstArray))
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Add(item);
                }
                else
                {
                    oddNumbers.Add(item);
                }
            }
            Console.WriteLine(String.Join(",", evenNumbers));
            Console.WriteLine(String.Join(",", oddNumbers));

        }
    }
}
