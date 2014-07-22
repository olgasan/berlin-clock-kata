public class BlockParser
{
	private int markerInterval;

	private bool ShouldAddMarkers
	{
		get { return (markerInterval > 0); }
	}

	public BlockParser ()
	{
		markerInterval = int.MinValue;
	}

	public BlockParser (int markerInterval)
	{
		this.markerInterval = markerInterval;
	}

	public string GetBlocksFromInt(int value, int numberOfBlocks, int size)
	{
		string[] blocks = IntToBlocksGroups(value, numberOfBlocks, size);
		string joinedBlocks = JoinBlocks (blocks);
		string formattedStr = AddMarkers (joinedBlocks);

		return formattedStr;
	}

	private string AddMarkers (string joinedBlocks)
	{
		if (!ShouldAddMarkers)
			return joinedBlocks;

		string modifiedBlocks = string.Empty;
		int markerCount = 0;
		int interval = this.markerInterval-1;

		for (int i=0; i<joinedBlocks.Length; i++)
		{
			bool isMarkerChar = false;
			
			if (joinedBlocks[i] == 'Y')
			{
				isMarkerChar = (markerCount >= interval);
				markerCount = (markerCount >= interval) ? 0 : (markerCount + 1);
			}

			modifiedBlocks = isMarkerChar ? (modifiedBlocks + "R") : (modifiedBlocks + joinedBlocks[i]);
		}

		return modifiedBlocks;
	}
	
	private string JoinBlocks(string[] blocks)
	{
		return string.Join("", blocks);
	}

	private string[] IntToBlocksGroups(int value, int numberOfBlocks, int blockSize)
	{
		int blocksOn = value/blockSize;
		return IntToBlocks (blocksOn, numberOfBlocks, blockSize);
	}
	
	private string[] IntToBlocks(int value, int numberOfBlocks, int blockSize)
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
}
