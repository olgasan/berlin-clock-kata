public class BerlinSingleMinutesRow  
{
	private BlockParser blockParser;

	public BerlinSingleMinutesRow()
	{
		blockParser = new BlockParser("Y");
	}

	public string ToBerlinFormat(string minutesStr)
	{
		return ParseSingleMinutesRow(minutesStr);
	}

	private string ParseSingleMinutesRow (string minutesStr)
	{
		int minutes = 0;
		int.TryParse (minutesStr, out minutes);
		
		if(minutes < 5)
			return blockParser.GetBlocksFromInt(minutes, 4, 1);
		else
			return "OOOO";
	}



}
