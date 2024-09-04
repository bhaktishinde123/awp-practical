class Factorial
   {  
     public static void Main(string[] args)  
      {  
       int i,fact=1,number;      
       System.Console.Write("Enter any Number: ");      
       number= int.Parse(System.Console.ReadLine());     
       for(i=1;i<=number;i++){      
        fact=fact*i;      
       }      
       System.Console.Write("Factorial of " +number+" is: "+fact);    
     }  
  }