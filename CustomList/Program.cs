using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            CustomBuiltList<string> testList2 = new CustomBuiltList<string>();
            CustomBuiltList<string> testList3 = new CustomBuiltList<string>();
            testList.Remove("hskdj");
            testList.Add("String 1");
            testList.Add("String 2");
            testList.Add("String 3");
            testList2.Add("Sfdsfsdfds");
            testList2.Add("dsfdfdsf");
            testList2.Add("String 3");
            foreach (string element in testList)
            {
                Console.WriteLine(element);
            }
            //testList3 = testList - testList2;
            //testList3.Display();
            ////List<string> realListOfStrings = new List<String>();
            ////realListOfStrings.Add("Hello");
            ////Console.WriteLine(realListOfStrings.ToString());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
