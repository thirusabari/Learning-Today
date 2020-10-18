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

			Console.WriteLine("Local Time to UTC Conversion");
			DateTime CreatedDate = new DateTime(2020, 10, 14, 17, 46, 01, 150);
			Console.WriteLine("CreatedDate = {0}", CreatedDate);
			Console.WriteLine();
			var CreatedDate_UniversalTime = CreatedDate.ToUniversalTime();
			Console.WriteLine("Created Date Universal Time = {0}", CreatedDate_UniversalTime);
			Console.WriteLine();
			Console.WriteLine();


			//UTC Date to EST Conversion
			Console.WriteLine("Coordinated Universal Time (UTC) is 4 hours ahead of Eastern Standard Time(EST)");
			Console.WriteLine();
			var utcDate = DateTime.UtcNow;
			Console.WriteLine("UTC to EST Conversion");
			Console.WriteLine();
			TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
			DateTime EasternTime = TimeZoneInfo.ConvertTimeFromUtc(utcDate, easternZone);
			Console.WriteLine("UTC Date {0} into EST Date = {1}", utcDate, EasternTime);
			Console.WriteLine();
			Console.WriteLine();



			//UTC to IST Conversion
			Console.WriteLine("Indian Standard Time (IST) is 5 hours 30 minutes ahead of Coordinated Universal Time (UTC)");
			Console.WriteLine();
			var utcNow = DateTime.UtcNow;
			Console.WriteLine("UTC to IST Conversion");
			Console.WriteLine();
			TimeZoneInfo indianZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
			DateTime IndianTime = TimeZoneInfo.ConvertTime(utcNow, indianZone);
			Console.WriteLine("UTC {0} to IST Date = {1}", utcNow, IndianTime);
			Console.WriteLine();
			Console.WriteLine();


			//IST to EST Conversion
			Console.WriteLine("Indian Standard Time(IST) is 9 hours and 30 minutes ahead of Eastern Standard Time(EST)");
			Console.WriteLine();
			var nowDate = DateTime.Now;
			Console.WriteLine("IST to EST Conversion");
			Console.WriteLine();
			TimeZoneInfo easternZone1 = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
			DateTime EasternTime1 = TimeZoneInfo.ConvertTime(nowDate, easternZone1);
			Console.WriteLine("IST Date {0} into EST Date = {1}", nowDate, EasternTime1);
			Console.WriteLine();
			Console.WriteLine();


			Console.ReadLine();
		}
	}
}
