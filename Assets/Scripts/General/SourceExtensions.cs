using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public static class SourceExtensions
{
	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
	{
		return source.Shuffle(new Random());
	}

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rng)
	{
		if (source == null) throw new ArgumentNullException(nameof(source));
		if (rng == null) throw new ArgumentNullException(nameof(rng));

		return source.ShuffleIterator(rng);
	}

	private static IEnumerable<T> ShuffleIterator<T>(
		this IEnumerable<T> source, Random rng)
	{
		var buffer = source.ToList();
		for (int i = 0; i < buffer.Count; i++)
		{
			int j = rng.Next(i, buffer.Count);
			yield return buffer[j];

			buffer[j] = buffer[i];
		}
	}

	public static T GetRandom<T>(this List<T> list)
	{
		return list.Shuffle().ToList()[0];
	}

	public static List<T> GetRandom<T>(this List<T> list, int num)
	{
		return list.Shuffle().Take(num).ToList();
	}
}

public static class BlightsourceExtensions
{
	public static Blightsource GetBlightsourceByWeight(this List<Blightsource> sources)
	{
		var indexesByWeight = new List<int>();

		for (int i = 0; i < sources.Count; i++)
		{
			indexesByWeight.AddRange(sources[i].rarity.GetWeight(i));
		}

		return sources[indexesByWeight.GetRandom()];
	}
}