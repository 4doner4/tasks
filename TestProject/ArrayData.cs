using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class ArrayData
    {
        public static void ArrayDataTask()
        {
            /*
             Дан массив данных 
                let array = [1,2,4,8]
            Напишите функцию, которая добавит в массив цифры 3, 5, 6, 7 в порядке возрастания 
             */
            int[] array = { 1, 2, 4, 8 };
            int[] secondArray = { 3, 5, 6, 7 };

            int[] insertedArray = secondArray
                .Concat(array)
                .ToArray();

            Array
                .Sort(insertedArray);
            Console.WriteLine(String
                .Join(",", insertedArray)
                );



        }
    }
}
