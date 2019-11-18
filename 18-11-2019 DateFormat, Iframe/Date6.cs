using System;
public class Program
{
	public static void Main(string[] args)
	{
		DateTime dt = new DateTime(2019,11,18);
		Console.WriteLine(dt.IsDaylightSavingTime());		//longer evening daylight in summer
		Console.WriteLine(DateTime.IsLeapYear(dt.Year));
	}
}
	