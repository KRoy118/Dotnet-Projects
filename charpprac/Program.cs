
using System;
using System.Linq;
using System.Collections.Generic;
namespace Solution
{
 class Program
 {
 public static void Main()
 {
 string name,branch;
 double balance;
 int accId,cIId;

 Bank manager = new Bank();
 int n = Convert.ToInt32(Console.ReadLine());

 for(int i=0;i<n;i++)
 {
 name = Console.ReadLine();
 accId = Convert.ToInt32(Console.ReadLine());
 cIId =Convert.ToInt32(Console.ReadLine());
 balance = Convert.ToDouble(Console.ReadLine());
 branch = Console.ReadLine();

 manager.accountList.Add(new Account(name,accId,cIId, balance, branch));
 }
 string ip = Console.ReadLine();
 manager.FindAccountWithHighBalance(ip);
 }
 }

 class Account
 {
 public string name{get;set;}
 public int accId{get;set;}
 public int cIId{get;set;}
 public double balance{get;set;}
 public string branch{get;set;}

 public Account(string name, int accId, int cIId,double balance, string branch)
 {
 this.name = name;
 this.accId = accId;
 this.cIId=cIId;
 this.balance = balance;
 this.branch = branch;
 }
 }

 class Bank
 {
 public List<Account> accountList = new List<Account>();


 // Method
 public Account FindAccountWithHighBalance(string branch)
 {
 Account ac =null;
 List<Account> account = new List<Account>();

 accountList.ForEach(bs => {
 if(bs.branch.ToLower().Equals(branch.ToLower()))
 {
 account.Add(bs);
 }
 });

 if(account.Count > 0)
 {
 // bus = (Bus) buses.Where(x => x.ticket_fare == buses.Min(y => y.ticket_fare)); or
 ac = account.OrderBy(x => x.balance).Last();
 Console.WriteLine($"{ac.name}:{ac.accId}:{ac.cIId}:{ac.balance}:{ac.branch}");
 return ac;
 }
 Console.WriteLine("No Account is available");
 return null;
 }

}
}