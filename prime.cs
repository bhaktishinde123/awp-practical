class Prime
{
      public static void Main() 
	{
         	int n, a = 0;
		System.Console.WriteLine("enter the number:");
		n =System.Convert.ToInt32(System.Console.ReadLine());
         	for (int i = 1; i <= n; i++) 
		{
            		if (n % i == 0)
			{
               			a++;
            		}
        	}
         	if (a == 2) 
		{
           		System.Console.WriteLine("{0} is a Prime Number");
        	} 
		else 
		{
            		System.Console.WriteLine("Not a Prime Number");
         	}
		
         	System.Console.ReadLine();
      	}
}