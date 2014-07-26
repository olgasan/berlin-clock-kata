
public class BerlinTime
{
	private FormattedTime formattedTime;

	private BerlinSecondsRow secondsRow;
	private BerlinSingleMinutesRow singleMinutesRow;
	private BerlinFiveMinutesRow fiveMinutesRow;
	private BerlinSingleHourRow singleHourRow;
	private BerlinFiveHourRow fiveHourRow;

	public string Second 
	{
		get { return secondsRow.ToBerlinFormat (formattedTime.Seconds); }
	}

	public string SingleMinute 
	{
		get { return singleMinutesRow.ToBerlinFormat(formattedTime.Minutes); }
	}

	public string FiveMinute 
	{
		get { return fiveMinutesRow.ToBerlinFormat (formattedTime.Minutes); }
	}

	public string FiveHourRow 
	{
		get { return fiveHourRow.ToBerlinFormat (formattedTime.Hours); }
	}

	public string SingleHourRow 
	{
		get { return singleHourRow.ToBerlinFormat (formattedTime.Hours); }
	}

	public BerlinTime (FormattedTime formattedTime)
	{
		this.formattedTime = formattedTime;

		secondsRow = new BerlinSecondsRow ();
		singleMinutesRow = new BerlinSingleMinutesRow ();
		fiveMinutesRow = new BerlinFiveMinutesRow ();

		FormatHours ();
	}

	public void FormatHours ()
	{
		singleHourRow = new BerlinSingleHourRow ();
		fiveHourRow = new BerlinFiveHourRow ();
	}
}
