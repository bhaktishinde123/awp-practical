class WhileTest
{
	private int n ;
	public void  Test()
	{
		n = 1;
		while(n<=10)
		{
			if(n%2 == 0)
			{
				n++;
			}
			else 
			{
				System.Console.WriteLine(" " +n);
				n++;
			}
		}	
	}
}
class MainWhileTest
{
	public static void Main(string[] args)
	{
		WhileTest obj = new WhileTest();
		obj.Test();
	}
}