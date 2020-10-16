using System;

namespace Learning_TimeZone
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("DateTime Object");
			var localTime = DateTime.Now;
			Console.WriteLine("LocalTime = {0}", localTime);
			Console.WriteLine();
			var utcTime = DateTime.UtcNow;
			Console.WriteLine("UTCTime = {0}", utcTime);
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("DateTimeOffset Object");
			var localDateTimeOffset = DateTimeOffset.Now;
			Console.WriteLine("Local DateTimeOffset = {0}", localDateTimeOffset);
			Console.WriteLine();
			var utcDateTimeOffset = DateTimeOffset.UtcNow;
			Console.WriteLine("UTC DateTimeOffset = {0}", utcDateTimeOffset);
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Local And Utc OffSet From DateTimeOffSetObject");
			var localOffSet = localDateTimeOffset.Offset;
			Console.WriteLine("Local Offset = {0}", localOffSet);
			Console.WriteLine();
			var utcOffset = utcDateTimeOffset.Offset;
			Console.WriteLine("UTC Offset = {0}", utcOffset);
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Local Time to Est Conversion");
			DateTime CreatedDate = new DateTime(2020, 10, 14, 17, 46, 01, 150);
			Console.WriteLine("CreatedDate = {0}", CreatedDate);
			Console.WriteLine();
			var CreatedDate_UniversalTime = CreatedDate.ToUniversalTime();
			Console.WriteLine("Created Date Universal Time = {0}", CreatedDate_UniversalTime);
			Console.WriteLine();
			Console.WriteLine();

			//Created Date to EST Conversion
			Console.WriteLine("Created Date to EST Conversion");

			Console.ReadLine();
		}
	}
}
