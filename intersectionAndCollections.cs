using System;
using System.Linq;

namespace ConsoleApp{
    class App{
        public static void Main(string[] args){
            string[] test1 = {"test1" , "test2" ,"test3" ,"test4"};
            string[] test0 = {"test5" , "test6" ,"test7" ,"test8"};

            var result = test1.Except(test0);
            
            foreach(string s in result) Console.WriteLine(s);
        }
    }
}