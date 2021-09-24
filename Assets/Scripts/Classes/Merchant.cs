using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Merchant
{
	public string name;
	public MerchantType focus;
	public Familiarity familiarity;

	public List<Blightsource> inventory;

	public Merchant(string nameVal, string focusVal, int familiarityThresholdVal)
	{
		focus = new MerchantType(focusVal);
		familiarity = new Familiarity(familiarityThresholdVal);
	}

	public void RefreshInventory()
	{
	}
}