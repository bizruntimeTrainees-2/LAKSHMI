using System;
using System.Threading;
using System.Threading.Tasks;


public class Program
{
	public static void Main(string[] args)
	{
		DateTime date = DateTime.Now;
		TimeSpan aMonth = new System.TimeSpan(30,0,0,0);
		DateTime dateAfterMonth = date.Add(aMonth);
		DateTime dateBeforeMonth = date.Subtract(aMonth);
		Console.WriteLine(dateAfterMonth);
		Console.WriteLine(dateBeforeMonth);
	}
}