public class Converter 
{
	public class FormattedTime
	{
		private string timeStr;

		public FormattedTime (string timeStr)
		{
			this.timeStr = timeStr;
		}

		public bool IsValidFormat ()
		{
			string[] timeSegments = timeStr.Split (':');
			return timeSegments.Length == 3;
		}
	}

	public BerlinTime ToBerlinFormat (string timeStr)
	{
		bool isValid = ValidateTime (timeStr);

		if (isValid)
		{
			return new BerlinTime ();
		}
		else
		{
			return null;
		}
	}

	private bool ValidateTime (string timeStr)
	{
		bool isValid = true;
		FormattedTime t = new FormattedTime (timeStr);

		if (!t.IsValidFormat ())
		{
			isValid = false;
			throw new System.ArgumentException ("Invalid Format");
		}

		return isValid;
	}
}

