using System;
using System.Collections.Generic;

public class ETL
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        var transformedData = new Dictionary<string, int>();
        old.Keys.Foreach(oldKey => old[oldKey].Foreach(oldValue => transformedData.Add(oldValue.ToLower(), oldKey)));
        return transformedData;
    }
}

public static class EnumerableExtensions
{
    public static void Foreach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
            action(item);
    }
}
