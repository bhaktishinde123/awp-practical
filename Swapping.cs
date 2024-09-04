class Hero
{
	public void Swaps()
	{
		int m = 100, n = 200;
		System.Console.WriteLine("Before Swapping");
		System.Console.WriteLine("m = " + m);
		System.Console.WriteLine("n = "+ n);
		Swap(ref  m, ref n);
		System.Console.WriteLine("After Swapping");
		System.Console.WriteLine("m = " + m);
		System.Console.WriteLine("n = "+ n);

	}
}
class Swapping
{
	public static void Main(string[] args)
	{
		Hero obj = new Hero();
		obj.Swaps();
	}
}
