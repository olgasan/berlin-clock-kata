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

	public override string ToBerlinFormat (string hoursStr)
	{
		hoursStr = RemoveDifference (hoursStr);
		return ParseTimeRow (hoursStr);
	}
}
