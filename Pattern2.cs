class Pattern2
{
	int a;
	public Pattern2(int x)
	{
		int a = x;
		for(int i = a; i>=1;i--)
		{
			for(int j = i; j>=1;j--)
			{
				System.Console.Write("$");
			}
			System.Console.WriteLine();
		}
	}
}
class MainPattern2
{
	public static void Main (string[] args)
	{
		Pattern2 obj = new Pattern2(5);
	}
}