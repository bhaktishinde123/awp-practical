class ReadPrice
{
	public static void Main(string[] args)
	{
	double a = System.Convert.ToDouble(args[0]);
	double paise =(int)( a *100);
	System.Console.WriteLine(paise + " " + "paise");
	}
	
}