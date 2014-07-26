public class Converter 
{
	public BerlinTime ToBerlinFormat (string timeStr)
	{
		FormattedTime formattedTime = new FormattedTime (timeStr);
		bool isValid = ValidateTime (formattedTime);

		if (isValid)
		{
			return new BerlinTime (formattedTime);
		}
		else
		{
			return null;
		}
	}

	private bool ValidateTime (FormattedTime t)
	{
		bool isValid = true;

		if (!t.IsValidFormat ())
		{
			isValid = false;
			throw new System.ArgumentException ("Invalid Format");
		}

		return isValid;
	}
}

public class FormattedTime
{
	private const int SECONDS = 2;
	private const int MINUTES = 1;
	private const int HOURS = 0;

	private string timeStr;
	private string[] timeSegments;

	public string Seconds { get { return timeSegments [SECONDS]; } }
	public string Minutes { get {return timeSegments [MINUTES]; } }
	public string Hours { get { return string.IsNullOrEmpty (timeSegments [HOURS]) ? "00" : timeSegments [HOURS]; } }

	public FormattedTime (string timeStr)
	{
		this.timeStr = timeStr;
		timeSegments = timeStr.Split (':');
	}
	
	public bool IsValidFormat ()
	{
		return timeSegments.Length == 3;
	}
}
