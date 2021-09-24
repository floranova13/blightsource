using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Rarity
{
	/// <summary>
	/// The lower the number, the rarer the blightsource.
	/// </summary>
	public int rarity;

	public Rarity(int rarityVal)
	{
		rarity = rarityVal;
	}

	public List<int> GetWeight(int i)
	{
		var weightList = new List<int>();

		for (int j = 0; j < rarity; j++)
		{
			weightList.Add(i);
		}

		return weightList;
	}
}