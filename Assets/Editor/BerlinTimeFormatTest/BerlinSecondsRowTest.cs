using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class BerlinSecondsRowTest
	{
		private BerlinSecondsRow secondsRow;

		[SetUp]
		public void SetUp ()
		{
			BerlinSecondsRow secondsRow = new BerlinSecondsRow ();
		}

		[Test]
		public void EvenSecondsAreConvertedToY ()
		{
			secondsRow = new BerlinSecondsRow ();
			Assert.AreEqual ("Y", secondsRow.ToBerlinFormat ("02"));
		}

		[Test]
		public void OddSecondsAreConvertedToO ()
		{
			secondsRow = new BerlinSecondsRow ();
			Assert.AreEqual ("O", secondsRow.ToBerlinFormat ("01"));
		}
	}
}
