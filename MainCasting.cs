class Casting
{
	private float sum = 0.0F;
	private int i;
	//sum = 0.0F;
	public void Cast()
	{
		for(i = 1; i<= 10 ; i++)
		{
			sum = sum + 1/(float)i;
			System.Console.WriteLine(" i = " + i);
			System.Console.WriteLine(" sum = " + sum);
			
		}
	}	
}
class MainCasting
{
	public static void Main(string[] args)
	{
		Casting obj = new Casting();
		obj.Cast();
	}
}