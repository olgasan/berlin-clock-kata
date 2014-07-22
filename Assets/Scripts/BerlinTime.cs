
public class BerlinTime
{
	private BerlinSecondsRow secondsRow;
	private BerlinSingleMinutesRow singleMinutesRow;
	private BerlinFiveMinutesRow fiveMinutesRow;

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

	public string FiveMinute 
	{
		get;
		private set;
	}

	public BerlinTime (FormattedTime formattedTime)
	{
		secondsRow = new BerlinSecondsRow ();
		singleMinutesRow = new BerlinSingleMinutesRow ();
		fiveMinutesRow = new BerlinFiveMinutesRow ();

		ParseSecondsRow (formattedTime);
		ParseSingleMinutesRow (formattedTime);
		ParseFiveMinutesRow (formattedTime);
	}

	private void ParseSecondsRow (FormattedTime formattedTime)
	{
		Second = secondsRow.ToBerlinFormat (formattedTime.Seconds);
	}

	private void ParseSingleMinutesRow (FormattedTime formattedTime)
	{
		SingleMinute = singleMinutesRow.ToBerlinFormat(formattedTime.Minutes);
	}

	private void ParseFiveMinutesRow (FormattedTime formattedTime)
	{
		FiveMinute = fiveMinutesRow.ToBerlinFormat (formattedTime.Minutes);
	}
}
