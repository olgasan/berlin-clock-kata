public class BerlinSecondsRow
{
	public string ToBerlinFormat (string secondsStr)
	{
		return ParseSecondsRow (secondsStr);
	}

	private string ParseSecondsRow (string secondsStr)
	{
		int seconds = 0;
		int.TryParse (secondsStr, out seconds);
		return (seconds % 2 == 0) ? "Y" : "O";
	}
}
