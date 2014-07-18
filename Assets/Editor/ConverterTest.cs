using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class ConverterTest
	{
		[Test]
		public void CanBeCreated ()
		{
			Converter converter = new Converter ();
			Assert.IsNotNull (converter);
		}

		[Test]
		[ExpectedException]
		public void RejectsInvalidFormat ()
		{
			Converter converter = new Converter ();
			converter.ToBerlinFormat ("00-00-00");
		}

		[Test]
		public void ReceivesTimeInFormatHHMMSS ()
		{
			Converter converter = new Converter ();

			string h = "01";
			string m = "02";
			string s = "03";
			string time = "{0}:{1}:{2}";
			time = string.Format (time, h, m, s);

			BerlinTime receivedTime = converter.ToBerlinFormat (time);
			Assert.IsNotNull (receivedTime);
		}
	}
}