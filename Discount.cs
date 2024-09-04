class Discount
{
	public static void Main(string[] args)
	{
		double totalamt = 0;
		string a = System.Convert.ToString(args [0]);
		double amt = System.Convert.ToDouble(args[1]);
		switch(a)
		{
			case "silkcloth":
				if (amt <= 100)
				{
					totalamt = amt;	
				}
				else if (amt <= 200)
				{
					totalamt = amt - (amt * 0.05);
				}
				else if (amt <= 300)
				{
					totalamt = amt - (amt * 0.075);
				}
				else
				{
					totalamt = amt - (amt * 0.1); 
				}
				break;
				
				
			case "handloom":
				if (amt<=100)		
				{
					totalamt = amt - (amt * 0.05);
				}
				else if (amt <= 200)
				{
					totalamt = amt - (amt * 0.075);
				}
				else if (amt <= 300)
				{
					totalamt = amt - (amt * 0.1);
				}
				else
				{
					totalamt = amt - (amt * 0.15);
				}
				break;
				}
				System.Console.WriteLine("Net amount for customer is:" + totalamt);
				
			
		}
		
	}
	

