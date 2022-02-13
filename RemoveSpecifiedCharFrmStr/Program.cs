//Remove specified a character from a non-empty string using index of a character
//Space  NOT counted as a char
using System;

namespace RemoveSpecifiedCharFrmStr
{
    class Program
    {int i;
        static void Main(string[] args)
        {   Console.Write("Enter the string: ");
            string str=Console.ReadLine();
            Console.Write("Enter the character order to be removed: ");
            int n=Convert.ToInt32(Console.ReadLine());
            //string str=str.Replace(" ","");
           // Console.WriteLine(str1);
            Console.Write("Output type1:");
            Console.WriteLine(str.Remove((n-1),1));
            Console.Write("Output type2:");
            Console.WriteLine(str.Replace( str[n-1],'\0') );
        }
    }
}
