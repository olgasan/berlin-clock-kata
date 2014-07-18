using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class ConverterTest
	{
		private Converter converter;

		[SetUp]
		public void SetUp ()
		{
			converter = new Converter ();
		}

		[Test]
		public void CanBeCreated ()
		{
			Assert.IsNotNull (converter);
		}

		[Test]
		[ExpectedException]
		public void RejectsInvalidFormat ()
		{
			converter.ToBerlinFormat ("00-00-00");
		}

		[Test]
		public void ReceivesTimeInFormatHHMMSS ()
		{
			string time = CreateTimeStr ("00", "01", "02");
			BerlinTime receivedTime = converter.ToBerlinFormat (time);

			Assert.IsNotNull (receivedTime);
		}

		[Test]
		public void EvenSecondsAreConvertedToY ()
		{
			string time = CreateTimeStr ("00", "00", "02");
			BerlinTime receivedTime = converter.ToBerlinFormat (time);
			
			Assert.AreEqual ("Y", receivedTime.Second);
		}

		[Test]
		public void OddSecondsAreConvertedToO ()
		{
			string time = CreateTimeStr ("00", "00", "01");
			BerlinTime receivedTime = converter.ToBerlinFormat (time);
			
			Assert.AreEqual ("O", receivedTime.Second);
		}

		private string CreateTimeStr (string hour, string minute, string second)
		{
			string time = "{0}:{1}:{2}";
			return string.Format (time, hour, minute, second);
		}

	}
}