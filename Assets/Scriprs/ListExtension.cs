using System.Collections.Generic;
using UnityEngine;

public static class ListExtension
{
    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Random<T>(this List<T> list)
    {
        var listCount = list.Count;
        if (listCount == 0) return default;
        var randomIndex = UnityEngine.Random.Range(0, listCount);
        return list[randomIndex];
    }
    
    // public static T Random<T>(this Dictionary<T, int> dic)
    // {
    //     var listCount = dic.Count;
    //     if (listCount == 0) return default;
    //     var randomIndex = UnityEngine.Random.Range(0, listCount);
    //     return dic.Keys;
    // }
}
