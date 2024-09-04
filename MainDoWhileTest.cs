class DoWhileTest
{
	private int row = 1, column, y;
	public void test()
	{
	System.Console.WriteLine("Multiplication Table \n");
	do
	{
		column = 1;

		do
	{
		y = row * column;
		System.Console.WriteLine(" " + y);
		column = column + 1;
	}
		while (column <= 3);

		System.Console.WriteLine("\n");
		row = row + 1;

	}
		while (row <= 3);	
	}
}
class MainDoWhileTest
{
	public static void Main(string[] args)
	{
		DoWhileTest obj = new DoWhileTest();
		obj.test();
	}
}
