class Ty2CLient
{
	public static void Main (string[] args)
	{
		
		int a = 101;
		//boxing
		object ob1 = (object)a;
		System.Console.WriteLine(ob1);

		int b = 102;
		//unboxing
		object ob2 = b;
		int c = (int)ob2;
		System.Console.WriteLine(ob2);
		System.Console.WriteLine(c);
		
	}
}