using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
namespace C_Sharp_String_Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("String Builder Learning");
			Console.WriteLine();
			StringBuilder Sb = new StringBuilder();
			
			
			//String
			Sb.Append("Hi! Welcome to String Builder ");

			//new List
			List<string> temporary = new List<string>() { "one", "two", "three" };
			foreach(var t in temporary)
			{
				Sb.Append(t);
			}

			//Append Line Method


			//Insert Method
			Sb.Insert(0, " Good Morning ");

			//Replace Method
			Sb.Replace("Hi", "Everyone");

			//Remove Method: "tri" will gets removed from the above string
			Sb.Remove(35,3);

			//Append Format Method
			Sb.AppendFormat(" This is {0} versio of Learning {1}={2} ", "1st", "Today", DateTime.Now.ToShortDateString());

			Sb.AppendLine();
			//AppendLine Method
			Sb.AppendLine(" End User Agreement");

			//string date = '2020-10-17 23:08:25.6285178 +00:00';
			//var dateformat = CultureInfo.InvariantCulture.DateTimeFormat.ShortDatePattern;
			//Sb.AppendFormat(dateformat, "2020-10-17 23:08:25.6285178 +00:00");

			Console.WriteLine();
			Console.WriteLine(" {0} = {1} (String Builder Length)", Sb.ToString(), Sb.Length);
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
