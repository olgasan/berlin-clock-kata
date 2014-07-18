
public class BerlinTime
{
	public string Second 
	{
		get;
		private set;
	}

	public string SingleMinute 
	{
		get;
		private set;
	}

	public BerlinTime (FormattedTime formattedTime)
	{
		int seconds = 0;
		int.TryParse (formattedTime.Seconds, out seconds);
		if (seconds % 2 == 0)
		{
			Second = "Y";
		}
		else
		{
			Second = "O";
		}

		int minutes = 0;
		int.TryParse (formattedTime.Minutes, out minutes);

		if(minutes == 1)
		{
			SingleMinute = "YOOO";
		}

	}


}
