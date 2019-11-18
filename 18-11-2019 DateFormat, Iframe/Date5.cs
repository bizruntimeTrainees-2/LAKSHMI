using System;
public class Program
{
	public static void Main(string[] args)
	{
		DateTime date = new DateTime(2019, 11,18);
		String[] dateFormats =date.GetDateTimeFormats();
		foreach(string format in dateFormats)
		{
			Console.WriteLine(format);
		}
	}
}