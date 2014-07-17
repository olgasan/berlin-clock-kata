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
	}
}