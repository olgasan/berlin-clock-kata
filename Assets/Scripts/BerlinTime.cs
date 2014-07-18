
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
		ParseSeconds (formattedTime);

		ParseMinutes (formattedTime);

	}


	private void ParseSeconds (FormattedTime formattedTime)
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
	}

	private void ParseMinutes (FormattedTime formattedTime)
	{
		int minutes = 0;
		int.TryParse (formattedTime.Minutes, out minutes);
		if(minutes < 5)
			SingleMinute = JoinBlocks(ParseIntToBlocks(minutes));
		else
			SingleMinute = "OOOO";
	}

	private string[] ParseIntToBlocks(int value)
	{
		int numberOfBlocks = 4;
		string[] blocks = new string[numberOfBlocks];
	
		for(int i = 0; i < blocks.Length; i++)
		{
			if(i < value )
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
