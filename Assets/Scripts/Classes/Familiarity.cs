using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Familiarity
{
	public int familiarity;
	public int familiarityThreshold;

	public Familiarity(int familiarityThresholdVal)
	{
		familiarity = 0;
		familiarityThreshold = familiarityThresholdVal;
	}

	public int getDiscount(int price)
	{
		return price * (100 - (familiarity / familiarityThreshold)) / 100;
	}
}