using System;
using System.Linq;

namespace App{
    class app{ 
        public static void Main(string[] args) {
            int[] nums = {1 , -2 , 3 , 0};
            
            var posNum =  from n in nums
                       where n > 0
                       select n;
            foreach (int i in posNum) Console.WriteLine(i + "");
            Console.WriteLine("тут должны быть значения из массива nums:");

            
        }
    }
}