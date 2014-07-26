using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class BerlinFiveHourRowTest 
	{
		private BerlinFiveHourRow hourRow;

		[SetUp]
		public void SetUp ()
		{
			hourRow = new BerlinFiveHourRow ();
		}

		[Test]
		public void FormatFiveHours ()
		{
			Assert.AreEqual ("ROOO", hourRow.ToBerlinFormat ("05"));
		}

		[Test]
		public void FormatFifteenHours ()
		{
			Assert.AreEqual ("RRRO", hourRow.ToBerlinFormat ("15"));
		}

		[Test]
		public void FormatTwentyThreeHours ()
		{
			Assert.AreEqual ("RRRR", hourRow.ToBerlinFormat ("23"));
		}
	}
}
