public class BlockParser
{

	public string GetBlocksFromInt(int value, int numberOfBlocks, int size)
	{
		return JoinBlocks(IntToBlocksGroups(value, numberOfBlocks, size));
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
