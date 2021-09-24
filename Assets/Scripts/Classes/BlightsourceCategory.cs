using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

[Serializable]
public class BlightsourceCategory
{
	public static readonly List<string> CATEGORIES = new List<string>()
	{
		"Blightstones", "Blightichors", "Blightfumes", "Blightflora", "Blightfungi", "Blightanomalies"
	};
	public static readonly Dictionary<string, List<string>> SUBCATEGORIES = new Dictionary<string, List<string>>()
	{
		{ "Blightstones", new List<string>() { "Blight Metals", "Crystalline Blight", "Blight Chunks" } },
		{ "Blightichors", new List<string>() { "Lifeblight", "Blightvenoms", "Blightmare Pastes" } },
		{ "Blightfumes", new List<string>() { "Rushblight Vapors", "Blight Miasmas", "Distortion Blightmists" } },
		{ "Blightflora", new List<string>() { "Blightblooms", "Blightpillars", "Blightangles" } },
		{ "Blightfungi", new List<string>() { "Blightshrooms", "Blightbleeds", "Blight Sporesprawls" } },
		{ "Blightanomalies", new List<string>() { "Minor Blightanomalies", "Greater Blightanomalies", "Superior Blightanomalies" } },
	};

	public readonly string category;
	public readonly string subcategory;

	public BlightsourceCategory(string subcategoryVal)
	{
		category = SUBCATEGORIES.First(pair => pair.Value.Contains(subcategoryVal)).Key;
		subcategory = subcategoryVal;
	}
}