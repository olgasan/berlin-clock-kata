using UnityEngine;
using System.Collections;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class BerlinSingleMinutesRowTest
	{
		private BerlinSingleMinutesRow singleMinuteRow;

		[SetUp]
		public void Setup()
		{
			singleMinuteRow = new BerlinSingleMinutesRow();
		}

		[Test]
		public void FormatOneMinute()
		{
			Assert.AreEqual("YOOO", singleMinuteRow.ToBerlinFormat("01"));
		}
	}
}
