using System;
using System.Threading;
using System.Threading.Tasks;


public class Program
{
	public static void Main(string[] args)
	{
		DateTime firstDate = new DateTime(2019, 11, 22);
		DateTime secondDate = new DateTime(2015,11,22);
		int result = DateTime.Compare(firstDate,secondDate);
		if(result < 0)
			Console.WriteLine("First date is earlier");
		else if(result == 0)
			Console.WriteLine("First and second dates are same");
		else 
			Console.WriteLine("First date is later");
	}
}