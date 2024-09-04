class Pain
{
	
	public void Tree()
	{
		System.Console.WriteLine(volume (10));
		System.Console.WriteLine(volume (2.5F,8));
		System.Console.WriteLine(volume (100L,75,15));
		
	}
	public static int volume(int x)
	{
		return(x*x*x);
	}
	public static double volume(float r,int h)
	{
		return(3.14*r*r*h);
	}
	public static long volume(long l,int b,int h)
	{
		return(l*b*h);
	}
}
class Overloading
{
	public static void Main(string[] args)
	{
		Pain obj = new Pain();
		obj.Tree();
	}
}