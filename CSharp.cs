public class StringTrial
{
	string str1,str2;
	public void Display()
	{	
		str1 = @"t/yit";
		str2 = "class";
		System.Console.Writeline("{0}",str1);
	}
}
class StringTrialClient
{
	public staic void Main(string[] args)
	{
		StringTrial obj =  new StringTrial();
		obj.Display();
	}
}