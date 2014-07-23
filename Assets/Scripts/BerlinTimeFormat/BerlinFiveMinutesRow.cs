public class BerlinFiveMinutesRow
{
	private const int MARKER_INTERVAL = 3;

	private BlockParser blockParser;

	public BerlinFiveMinutesRow ()
	{
		blockParser = new BlockParser ("Y", "R", MARKER_INTERVAL);
	}

	public string ToBerlinFormat (string minutesStr)
	{
		return ParseFiveMinutesRow (minutesStr);
	}

	private string ParseFiveMinutesRow (string minutesStr)
	{
		int minutes = 0;
		int.TryParse (minutesStr, out minutes);
		
		if(minutes >= 5)
			return blockParser.GetBlocksFromInt(minutes, 11, 5);
		else
			return "OOOOOOOOOOO";
	}
}
