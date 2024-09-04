class ForeachTest
{
	public void Test()
	{
		int[] arrayInt = { 11, 22, 33, 44};
		foreach(int m in arrayInt)
		{
			System.Console.WriteLine(" " + m);
		}
		System.Console.WriteLine();
	}
}
class MainForeachTest
{
	public static void Main(string[] args)
	{
		ForeachTest  obj = new ForeachTest();
		obj.Test();
	}
}