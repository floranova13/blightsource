using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

[Serializable]
public class Blightsource
{
	public string name;
	public Worth worth;
	public BlightsourceCategory category;
	public Rarity rarity;

	public Blightsource(string nameVal, int worthVal, string worthRange, string subcategory, int rarityVal)
	{
		name = nameVal;
		worth = new Worth(worthVal, worthRange);
		category = new BlightsourceCategory(subcategory);
		rarity = new Rarity(rarityVal);
	}
}