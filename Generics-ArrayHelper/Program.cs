using System;

namespace Generics_ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int Array");
            ArrayHelper<int> arrayHelper1 = new ArrayHelper<int>(new int[] { 2,8,5,6,3,4,1,10,78});
            
            var index= arrayHelper1.ReturnIndex(4);
            Console.WriteLine($"The position of the element is {index}");

            var array = arrayHelper1.ReturnArray(2,3);
            Console.Write("The new array is: ");
            foreach(var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n");



            Console.WriteLine("String Array");
            ArrayHelper<string> arrayHelper2 = new ArrayHelper<string>(new string[] { "abc", "def", "ghi", "jkl", "mno"});

            var index2 = arrayHelper2.ReturnIndex("ghi");
            Console.WriteLine($"The position of the element is {index2}");

            var array2 = arrayHelper2.ReturnArray(2, 3);
            Console.Write("The new array is: ");
            foreach (var item in array2)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
