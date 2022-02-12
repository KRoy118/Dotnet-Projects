using System;
using System.Linq;
using System.Collections.Generic;

namespace csharpproj
{
    class Program
    {
        public static void Main()
        {
            string name,branch;int accid,clid;double balance;
            Bank man = new Bank();
            int n=Convert.ToInt32(Console.ReadLine());
            int i;
            
        
            for(i=0;i<n;i++)
            {
                name=Console.ReadLine();
                accid=Convert.ToInt32(Console.ReadLine());
                clid=Convert.ToInt32(Console.ReadLine());
                balance=Convert.ToDouble(Console.ReadLine());
                branch=Console.ReadLine();

                man.accountList.Add(new Account(name,accid,clid,balance,branch));


            }
            string ip=Console.ReadLine();
            man.Func(ip);

        }
    }

    class Account
    {
        public string name{get;set;}
        public int accid{get;set;}
        public int clid{get;set;}
        public double balance{get;set;}
        public string branch{get;set;}

        public Account(string name,int accid,int clid,double balance,string branch){
            this.name=name;
            this.accid=accid;
            this.clid=clid;
            this.balance=balance;
            this.branch=branch;

        }

    }


    class Bank
    {
        public List<Account> accountList=new List<Account>();
        public Account Func(string branch)

        {
                  Account ac= null;
                  List<Account>account=new List<Account>();
                  accountList.ForEach(bs=>{
                      if(bs.branch.ToLower().Equals(branch.ToLower()))
                      {
                          account.Add(bs);
                      }
                      });

                      if(account.Count>0)
                      {
                          ac=account.OrderBy(x=>x.balance).Last();
                          Console.WriteLine($"{ac.name}:{ac.accid}:{ac.clid}:{ac.balance}:{ac.branch}");
                          return ac;

                      }
Console.WriteLine("No account Available");
return null;
                  
        }
        
    }


}



