class RelationalOperators
{
	private float a = 15.0F, b = 20.75F, c = 15.0F;
	public void Relationalo()
	{
		System.Console.WriteLine(" a = " +a);
		System.Console.WriteLine(" b = " +b);
		System.Console.WriteLine(" c = " +c);
		System.Console.WriteLine(" a<b is = " +(a<b));
		System.Console.WriteLine(" a>b is = " +(a>b));
		System.Console.WriteLine(" a==c is = " +(a==c));
		System.Console.WriteLine(" a<=c is = " +(a<=c));
		System.Console.WriteLine(" a>=b is = " +(a>=b));
		System.Console.WriteLine(" b!=c is = " +(b!=c));
		System.Console.WriteLine(" b== a+c is = " +(b==a+c));
		 
	}
}
class MainRelationalOperators
{
	public static void Main(string[] args)
	{
		RelationalOperators obj = new RelationalOperators();
		obj.Relationalo();
	}
}