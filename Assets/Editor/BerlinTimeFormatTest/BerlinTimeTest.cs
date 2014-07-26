using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class BerlinTimeTest 
	{
		[Test]
		public void FormatSixteenHours ()
		{
			FormattedTime fTime = new FormattedTime ("16:00:00");
			BerlinTime bTime = new BerlinTime (fTime);

			Assert.AreEqual ("RRRO", bTime.FiveHourRow);
			Assert.AreEqual ("ROOO", bTime.SingleHourRow);
		}
	}
}
