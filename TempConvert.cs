class TempConvert
{
	public static void Main(string[] args)
	{
		double c;
		double f = System.Convert.ToDouble(args [0]);
		c = f - 32/1.75F;
		System.Console.WriteLine(c);
	}
}