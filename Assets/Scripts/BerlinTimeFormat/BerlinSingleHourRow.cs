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
		return ParseTimeRow (hourStr);
	}
}
