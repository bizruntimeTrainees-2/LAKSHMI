using System;
using System.Threading;
using System.Threading.Tasks;


public class Program
{
	public static void Main(string[] args)
	{
		int days = DateTime.DaysInMonth(2019,3);
		Console.WriteLine(days);
	}
}