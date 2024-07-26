class Expressions
{
	private int a = 10, b = 5, c = 8 , d = 2;
	private float x = 6.4F , y = 3.0F;
	public void Express()
	{
		int answer1 = a * b + c / d;
		int answer2 = a * (b+c) /d;
		int answer3 = a % c;
		float answer4 = x % y;
		bool bool1 = a>b && c>d;
		bool bool2 = a<b && c>d;
		bool bool3 = a<b || c>d;
		bool bool4 = !(a-b == c);
		System.Console.WriteLine("order of evalution");
		System.Console.WriteLine(" a + b + c /d = " + answer1);
		System.Console.WriteLine(" a * (b + c) /d = " + answer2);
		System.Console.WriteLine(" Modulo operation");
		System.Console.WriteLine(" a % c" + answer3);
		System.Console.WriteLine(" x % y" + answer4);
		System.Console.WriteLine(" Logical Operations");
		System.Console.WriteLine(" a>b && c>d" + bool1);
		System.Console.WriteLine(" a<b && c>d" + bool2);
		System.Console.WriteLine(" a<b || c>d " + bool3);
		System.Console.WriteLine(" !(a-b) == c" + bool4);
	}
	
}
class MainExpression
{
	public static void Main(string[] args)
	{
		Expressions obj = new Expressions();
		obj.Express();
	}	
}