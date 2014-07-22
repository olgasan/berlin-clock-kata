using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class BerlinFiveMinutesRowTest
	{
		private BerlinFiveMinutesRow fiveMinutesRow;
		
		[SetUp]
		public void SetUp ()
		{
			fiveMinutesRow = new BerlinFiveMinutesRow ();
		}
		
		[Test]
		public void FormatFiveMinutes ()
		{
			Assert.AreEqual ("YOOOOOOOOOO", fiveMinutesRow.ToBerlinFormat ("05"));
		}

		[Test]
		public void FormatFifteenMinutes ()
		{
			Assert.AreEqual ("YYROOOOOOOO", fiveMinutesRow.ToBerlinFormat ("15"));
		}

		[Test]
		public void FormatFiftyFiveMinutes ()
		{
			Assert.AreEqual ("YYRYYRYYRYY", fiveMinutesRow.ToBerlinFormat ("55"));
		}
	}
}
