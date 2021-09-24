using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Worth
{
	public readonly int val;
	public readonly string volatility;

	public int Val
	{
		get // In case I ever implement global price modifiers
		{
			return val;
		}
	}

	public Worth(int num, string volatilityVal)
	{
		val = num;
		volatility = volatilityVal;
	}

	public int getSellVal()
	{
		switch (volatility)
		{
			case "Fluid":
				return UnityEngine.Random.Range(val * 2 / 3, val * 4 / 3);

			case "Volatile":
				return UnityEngine.Random.Range(val / 3, val * 5 / 3);

			default:
				return Val;
		}
	}
}