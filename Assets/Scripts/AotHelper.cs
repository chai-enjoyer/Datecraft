using System.Collections.Generic;
using UnityEngine;

public static class AotHelper
{
    [RuntimeInitializeOnLoadMethod]
    public static void EnsureCollections()
    {
        var list = new List<string>();
        var dict = new Dictionary<string, int>();
        var dictString = new Dictionary<string, string>();
        var nestedDict = new Dictionary<string, Dictionary<string, int>>();
        var nestedList = new List<Dictionary<string, int>>();
        Debug.Log("AOT Helper initialized for Json.NET collections");
    }
}