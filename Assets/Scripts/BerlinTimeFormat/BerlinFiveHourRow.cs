using UnityEngine;
using System.Collections;

public class BerlinFiveHourRow : BerlinRow 
{
	protected override int NumberOfBlocks 
	{
		get { return 4; }
	}

	protected override int NumberOfUnitsPerBlock 
	{
		get { return 5; }
	}

	public BerlinFiveHourRow ()
	{
		blockParser = new BlockParser ("R");
	}

	protected override bool ShouldBeEmpty (int value)
	{
		return !(value >= NumberOfUnitsPerBlock);
	}

	public override string ToBerlinFormat (string valueStr)
	{
		return ParseTimeRow (valueStr);
	}
}
