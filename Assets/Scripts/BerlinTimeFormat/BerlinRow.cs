public abstract class BerlinRow
{
	protected BlockParser blockParser;

	protected abstract int NumberOfBlocks{get;}
	protected abstract int NumberOfUnitsPerBlock{get;}

	public abstract string ToBerlinFormat (string valueStr);

	protected abstract bool ShouldBeEmpty(int value);

	protected int ConvertToInt (string value)
	{
		int v = 0;
		int.TryParse (value, out v);
		return v;
	}

	protected string ConvertToString (int value)
	{
		return value > 9 ? value.ToString () : "0"+value;
	}

	protected string GetEmptyRow()
	{
		return blockParser.GetBlocksFromInt(0,NumberOfBlocks,NumberOfUnitsPerBlock);
	}

	protected string GetBlocksFromInt(int value)
	{
		return blockParser.GetBlocksFromInt(value, NumberOfBlocks, NumberOfUnitsPerBlock);
	}

	protected string ParseTimeRow (string valueStr)
	{
		int value = ConvertToInt (valueStr);
		
		if(ShouldBeEmpty(value))
			return GetEmptyRow();
		else
			return GetBlocksFromInt(value);
	}
}
