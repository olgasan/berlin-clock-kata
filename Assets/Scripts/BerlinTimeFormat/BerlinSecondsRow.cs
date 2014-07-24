﻿public class BerlinSecondsRow : BerlinRow
{
	protected override int NumberOfBlocks {	get {return 1;} }
	protected override int NumberOfUnitsPerBlock { get {return 1;} }
	
	public BerlinSecondsRow()
	{
		blockParser = new BlockParser("Y");
	}

	protected override bool ShouldBeEmpty (int value)
	{
		return !(value % 2 == 0);
	}

	public override string ToBerlinFormat (string secondsStr)
	{
		return ParseTimeRow (secondsStr);
	}
}
