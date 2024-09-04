class IfElseTest
{
	public void Test()
	{
		int[] number = {50,65,56,71,81};
		int even = 0, odd = 0;
		for(int i = 0; i < number.Length ; i++)
		{
			if((number[i] % 2) == 0)
			{
				even += 1;
				
			}
			else 
			{
				odd += 1;
			}
			System.Console.WriteLine("even number : " + even);
			System.Console.WriteLine("odd number : " + odd);
		}
	}
}
class MainIfElseTest
{
	public static void Main(string[] args)
	{
		IfElseTest obj = new IfElseTest();
		obj.Test();
	}
}