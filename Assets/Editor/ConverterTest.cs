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
		public void FormatSingleMinutesRow()
		{
			string time = CreateTimeStr("16", "01", "00");
			BerlinTime receivedTime = converter.ToBerlinFormat (time);

			Assert.AreEqual("YOOO", receivedTime.SingleMinute);

			time = CreateTimeStr("16", "02", "00");
			receivedTime = converter.ToBerlinFormat (time);
			Assert.AreEqual("YYOO", receivedTime.SingleMinute);

			time = CreateTimeStr("16", "05", "00");
			receivedTime = converter.ToBerlinFormat (time);
			Assert.AreEqual("OOOO", receivedTime.SingleMinute);
		}

		[Test]
		public void FormatFiveMinutesRow()
		{
			string time = CreateTimeStr("16", "05", "00");
			BerlinTime receivedTime = converter.ToBerlinFormat (time);
			
			Assert.AreEqual("YOOOOOOOOOO", receivedTime.FiveMinute);
		}

		private string CreateTimeStr (string hour, string minute, string second)
		{
			string time = "{0}:{1}:{2}";
			return string.Format (time, hour, minute, second);
		}

	}
}