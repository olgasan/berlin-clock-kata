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
			secondsRow = new BerlinSecondsRow ();
		}

		[Test]
		public void EvenSecondsAreConvertedToY ()
		{
			Assert.AreEqual ("Y", secondsRow.ToBerlinFormat ("02"));
		}

		[Test]
		public void OddSecondsAreConvertedToO ()
		{
			Assert.AreEqual ("O", secondsRow.ToBerlinFormat ("01"));
		}
	}
}
