
public class BerlinTime
{
	private BerlinSecondsRow secondsRow;

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
		int minutes = 0;
		int.TryParse (formattedTime.Minutes, out minutes);

		if(minutes < 5)
			SingleMinute = JoinBlocks(ParseIntToBlocks(minutes, 4, 1));
		else
			SingleMinute = "OOOO";
	}

	private void ParseFiveMinutesRow (FormattedTime formattedTime)
	{
		int minutes = 0;
		int.TryParse (formattedTime.Minutes, out minutes);

		if(minutes >= 5)
			FiveMinute = JoinBlocks(ParseIntToBlocks(minutes, 11, 5));
		else
			FiveMinute = "OOOOOOOOOOO";
	}
	
	private string[] ParseIntToBlocks(int value, int numberOfBlocks, int blockSize)
	{
		int blocksOn = value/blockSize;
		return SimpleParseIntToBlocks (blocksOn, numberOfBlocks, blockSize);
 	}

	private string[] SimpleParseIntToBlocks(int value, int numberOfBlocks, int blockSize)
	{
		string[] blocks = new string[numberOfBlocks];
		
		for(int i = 0; i < blocks.Length; i++)
		{
			if(i < value)
				blocks[i] = "Y";
			else
				blocks[i] = "O";
		}
		
		return blocks;
	}

	private string JoinBlocks(string[] blocks)
	{
		return string.Join("", blocks);
	}
}
