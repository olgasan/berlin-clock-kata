﻿public class BlockParser
{
	private int markerInterval;
	private string turnedOffStr;
	private string turnedOnStr;
	private string markerStr;

	private char CharForTurnedOn
	{
		get { return turnedOnStr[0]; }
	}

	private bool ShouldAddMarkers
	{
		get { return (markerInterval > 0); }
	}

	public BlockParser (string charForTurnedOn)
	{
		this.turnedOffStr = "O";
		this.turnedOnStr = charForTurnedOn;
		markerInterval = int.MinValue;
	}

	public BlockParser (string charForTurnedOn, string charForMarker, int markerInterval) : this (charForTurnedOn)
	{
		this.markerStr = charForMarker;
		this.markerInterval = markerInterval;
	}

	public string GetBlocksFromInt(int value, int numberOfBlocks, int size, bool includeZero)
	{
		string[] blocks = IntToBlocksGroups(value, numberOfBlocks, size, includeZero);
		string joinedBlocks = JoinBlocks (blocks);
		string formattedStr = AddMarkers (joinedBlocks);
		
		return formattedStr;
	}

	public string GetBlocksFromInt(int value, int numberOfBlocks, int size)
	{
		return GetBlocksFromInt (value, numberOfBlocks, size, false);
	}

	private string AddMarkers (string joinedBlocks)
	{
		if (!ShouldAddMarkers)
			return joinedBlocks;

		string modifiedBlocks = string.Empty;
		int markerCount = 0;
		int interval = this.markerInterval-1;

		for (int i=0; i<joinedBlocks.Length; i++)
		{
			bool isMarkerChar = false;
			
			if (joinedBlocks[i] == CharForTurnedOn)
			{
				isMarkerChar = (markerCount >= interval);
				markerCount = (markerCount >= interval) ? 0 : (markerCount + 1);
			}

			modifiedBlocks = isMarkerChar ? (modifiedBlocks + markerStr) : (modifiedBlocks + joinedBlocks[i]);
		}

		return modifiedBlocks;
	}
	
	private string JoinBlocks(string[] blocks)
	{
		return string.Join("", blocks);
	}

	private string[] IntToBlocksGroups(int value, int numberOfBlocks, int blockSize, bool includeZero)
	{
		int blocksOn = value/blockSize;
		return IntToBlocks (blocksOn, numberOfBlocks, blockSize, includeZero);
	}
	
	private string[] IntToBlocks(int value, int numberOfBlocks, int blockSize, bool includeZero)
	{
		string[] blocks = new string[numberOfBlocks];
		
		for(int i = 0; i < blocks.Length; i++)
		{
			if(i < value || (includeZero && value==0))
				blocks[i] = turnedOnStr;
			else
				blocks[i] = turnedOffStr;
		}
		
		return blocks;
	}
}
