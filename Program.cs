 public class Program
{
	public string a1;
	public string a2;
}

public class Program2
{
	public static void Main(string [] args)
	{
	Program obj = new Program();
	obj.a1 = "bhakti";
	obj.a2 = "shinde";
	System.Console.WriteLine("{0} {1}",obj.a1,obj.a2);
	}
} 