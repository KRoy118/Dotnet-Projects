### Question: 
Title:  Title: Bank management  
Create a console based application to do a certain operations based on the constraints as given below. 
Create a class called Account with the below 
attributes:  name-String, accId-int, cIId-int ,balance – double ,branch - String 
Generate necessary public properties. 
Create a constructor for Account class which takes parameters name, accId, cIId, balance and branch and assign values to properties. 
Create class Bank with attributes & methods given below: 
a.Attribute: 
A list of type Account, named as accountList. 
b.Method: 
A method named FindAccountWithHighBalance, will take string parameter as branch. 
It should return the Account object having maximum balance for the given branch argument.  
Note : 
All the comparisons are case insensitive.  
Create an object as manager for Bank class . Create an object of Account after reading the attribute data related to it with the given sequence of arguments to fulfill the constructor requirements mentioned.Add the object created above to the list named “accountList” of Bank object “manager”. 
This step repeats for the number of Account objects, mentioned in the first line of input (testcase input).Next you need to take a string for branch as input and call method FindAccountWithHighBalance.     
If no Account is found having branch same as input branch then print “No Account is available” otherwise  print "{name}:{accId}:{cIId}:{balance}:{branch}", excluding the square brackets and double quotes for the Account object returned from method having maximum balance.  

Testcases Configured for Evaluation: 
Testcase 1 (public testcase): 
Input :
4 
Varun
111
1122
5000 
Chennai
Raju
112 
3212
6500
Bangalore 
Laksha 
113
2334 
3400 
Chennai
Akshay 
115
3115 
4500 
Chennai 
Chennai 

Output: 
Varun:111:1122:5000:Chennai  

