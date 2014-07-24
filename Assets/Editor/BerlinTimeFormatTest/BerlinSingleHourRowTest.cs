using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class BerlinSingleHourRowTest 
	{
		private BerlinSingleHourRow singleHourRow;

		[SetUp]
		public void SetUp ()
		{
			singleHourRow = new BerlinSingleHourRow ();
		}

		[Test]
		public void FormatOneHour ()
		{
			Assert.AreEqual ("ROOO", singleHourRow.ToBerlinFormat ("01"));
		}
	}
}
