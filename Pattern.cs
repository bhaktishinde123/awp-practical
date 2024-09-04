class Pattern
{
	int a;
	public Pattern(int x)
	{
		a = x;
		for(int i = 1; i<=a ; i++)
		{
			System.Console.WriteLine();
			for(int j = 1 ; j<=i; j++)
			{
				System.Console.Write(i);
			}
		}	
	}
}
class MainPattern
{
	public static void Main(string[] args)
	{
		Pattern obj = new Pattern(5);
	}
}