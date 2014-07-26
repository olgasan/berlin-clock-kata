public class BerlinSingleHourRow : BerlinRow
{
	protected override int NumberOfBlocks {	get {return 4;} }
	protected override int NumberOfUnitsPerBlock { get {return 1;} }
	

	public BerlinSingleHourRow ()
	{
		blockParser = new BlockParser ("R");
	}

	protected override bool ShouldBeEmpty (int value)
	{
		return !(value <= NumberOfBlocks);
	}

	public override string ToBerlinFormat (string hourStr)
	{
		int hours = ConvertToInt (hourStr);
		int limit = NumberOfBlocks + 1;
		if (hours > NumberOfBlocks)
		{
			int multiplier = hours / limit;
			int difference = (multiplier * limit);
			hours = hours - difference;

			hourStr = ConvertToString (hours);
		}

		return ParseTimeRow (hourStr);
	}
}
