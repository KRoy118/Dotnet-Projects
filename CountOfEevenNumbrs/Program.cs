// Count of even numbers present in entered array

using System;
using System.Linq;
using System.Collections.Generic;
namespace Solution
{
 class Program
 {
 public static void Main()
 {int i;
 int n=Convert.ToInt32(Console.ReadLine());
 int [] ar=new int[n];
 for( i=0;i<n;i++)
 { ar[i]=Convert.ToInt32(Console.ReadLine());
   
 }
 int c=0;
 for(i=0;i<ar.Length;i++)
 {
     if(ar[i]%2==0)
     c ++ ;
 }
 Console.WriteLine(c);

 }

}
}