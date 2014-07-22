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
			Assert.AreEqual("YOOOOOOOOOO", fiveMinutesRow.ToBerlinFormat ("05"));
		}
	}
}
