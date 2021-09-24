using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class MerchantType
{
	public static readonly List<string> SPECIALTIES = new List<string>()
	{
		"General", "Blightstones", "Blightichors", "Blightfumes", "Blightflora", "Blightfungi"
	};

	public static readonly Dictionary<string, List<string>> FOCUSES = new Dictionary<string, List<string>>()
	{
		{ "General", new List<string>() { "Scavenger", "X", "Collector" } },
		{ "Blightstones", new List<string>() { "X", "X", "X" } },
		{ "Blightichors", new List<string>() { "X", "X", "X" } },
		{ "Blightfumes", new List<string>() { "X", "X", "x" } },
		{ "Blightflora", new List<string>() { "X", "X", "X" } },
		{ "Blightfungi", new List<string>() { "X", "X", "X" } },
	};

	public readonly string specialty;
	public readonly string focus;

	public MerchantType(string focusVal)
	{
		specialty = FOCUSES.First(pair => pair.Value.Contains(focusVal)).Key;
		focus = focusVal;
	}
}