using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlightsourceStats
{
	public bool volatilityResearched;
	public int amountTraded;
	public int profits;

	public BlightsourceStats()
	{
		volatilityResearched = false;
		amountTraded = 0;
		profits = 0;
	}

	public void Trade(bool buy, int val, int quantity)
	{
		if (buy)
		{
			profits -= val * quantity;
		}
		else
		{
			profits += val * quantity;
		}

		amountTraded++;
	}
}