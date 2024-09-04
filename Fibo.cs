class Fibo
{
	public static void Main(string[] args)
	{	
		int a = 0, b= 1, c;
		int number = System.Convert.ToInt32(args[0]);
		System.Console.WriteLine(a + "\n" + b);
		for(int i = 2;i<number;i++)
		{
			c = a + b;
			System.Console.WriteLine(c + " ");
			a = b;
			b = c;
		}
		
		
	}
}