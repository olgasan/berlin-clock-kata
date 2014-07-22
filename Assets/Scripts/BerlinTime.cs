
public class BerlinTime
{
	private BerlinSecondsRow secondsRow;
	private BerlinSingleMinutesRow singleMinutesRow;
	private BlockParser blockParser;

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
		blockParser = new BlockParser();

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
		int minutes = 0;
		int.TryParse (formattedTime.Minutes, out minutes);

		if(minutes >= 5)
			FiveMinute = blockParser.GetBlocksFromInt(minutes, 11, 5);
		else
			FiveMinute = "OOOOOOOOOOO";
	}
}
