public class BerlinFiveMinutesRow : BerlinRow
{
	private const int MARKER_INTERVAL = 3;

	protected override int NumberOfBlocks {	get {return 11;} }
	protected override int NumberOfUnitsPerBlock { get {return 5;} }

	public BerlinFiveMinutesRow ()
	{
		blockParser = new BlockParser ("Y", "R", MARKER_INTERVAL);
	}

	protected override bool ShouldBeEmpty (int value)
	{
		return !(value >= NumberOfUnitsPerBlock );
	}

	public override string ToBerlinFormat (string minutesStr)
	{
		return ParseTimeRow (minutesStr);
	}	
}
