usins System;
class MathTest
{
	public void Math()
	{
		System.Console.WriteLine("sines of angle from 0 to 90 degree");
		for(double theta = 0.0 ; theta<=90.00; theta + = 15)
		{
			double x = Math.Sin (theta * Math.PI/180);
			System.Console.WriteLine("Sin" + theta);
			System.Console.WriteLine(" ={0:F4}" + x );
			
		}
	}
}
class MainMathTest
{
	public static void Main(string[] args)
	{
		MathTest obj = new MathTest();
		obj.Math();
	}
}