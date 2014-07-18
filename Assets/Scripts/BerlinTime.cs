
public class BerlinTime
{
	public string Second 
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
	}
}
