using System;
using System.Linq;

namespace ConsoleApp
{
    /*
    public class App
    {
        public static void Main(string[] args){
            int[] nums = {1 ,21212 ,3 ,4};

            var postNum = from n in nums orderby n descending  select n;
            
            Console.Write("значение по нарастающей");
            

            foreach(int i in postNum) Console.WriteLine(i + "");
        }
    }
    */


    public class Acc{
        public string fristName { get; private set;}
        public string LastName {get; private set;}
        public string Balance {get; private set;}
        public string AccountNumber {get; private set;}
        public Account(string fn, string ln , double bl , string ac){
            FirstName = fn;
            LastName = ln;
            Balance = bl;
            AccountNumber = ac;
        }
    }

    class OrederdBy{
        public static void Main(string[] args){
            new Acc {"test" , "test1" , "test2" , 3.3434};
            new Acc {"test" , "test1" , "test2" , 2.3434};
            new Acc {"test" , "test1" , "test2" , 1.3434};
       

            var accInfo = from ace in Acc orderby acc.LastName , acc.FirstName, acc.Balance , acc.AccountNumber select acc;
            Console.WriteLine("счёт в отсортированом порядке");

            string str = "";

            foreach(Acc acc in accInfo){
                if(str!= acc.fristName){
                    Console.WriteLine();
                    str = acc.FirstName;
                }

                Console.WriteLine(acc.LastName, acc.fristName , acc.accountNumber , acc.Balance);
            }

            Console.WriteLine();
        }
    }
}
