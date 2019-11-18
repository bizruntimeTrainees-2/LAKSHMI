using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		DateTime date = DateTime.Now;
		Console.WriteLine(date.ToString("MM/dd/yyyy"));
		Console.WriteLine(date.ToString("dddd, dd/MM/yyyy"));
		Console.WriteLine(date.ToString("hh/mm/ss tt"));
	}
}