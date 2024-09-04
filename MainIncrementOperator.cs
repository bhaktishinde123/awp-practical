
class IncrementOperator
{
	private int m = 10, n = 20;
	public void Increment()
	{
		System.Console.WriteLine("m = " + m);
		System.Console.WriteLine("n = " + n);
		System.Console.WriteLine("++m = " + ++m);
		System.Console.WriteLine("n++ = " + n++);
		System.Console.WriteLine("m = " + m);
		System.Console.WriteLine("n = " + n);
		
		
	}
}
class MainIncrementOperator
{
	public static void Main(string[] args)
	{
		IncrementOperator obj = new IncrementOperator();
		obj.Increment();		
	}
}