using System;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args){
            int[] nums = { -1, 1 ,2 ,3 ,4};
            
            var postNum = from n in nums where n > 0 where n < 10 select n;

            Console.Write("ниже чем нуль");
            
            foreach (int i in postNum) Console.WriteLine(i + "");
            
            Console.WriteLine();
            
        }
    }
}