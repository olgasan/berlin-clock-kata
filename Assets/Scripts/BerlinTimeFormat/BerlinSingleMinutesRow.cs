public class BerlinSingleMinutesRow : BerlinRow
{
	protected override int NumberOfBlocks {	get {return 4;} }
	protected override int NumberOfUnitsPerBlock { get {return 1;} }

	protected override bool ShouldBeEmpty (int value)
	{
		return !(value <= NumberOfBlocks);
	}

	public BerlinSingleMinutesRow()
	{
		blockParser = new BlockParser("Y");
	}

	public override string ToBerlinFormat(string minutesStr)
	{
		return ParseTimeRow(minutesStr);
	}
}
