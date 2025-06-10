using System.Collections.Generic;
using UnityEngine;

public static class AotHelper
{
    [RuntimeInitializeOnLoadMethod]
    public static void EnsureCollections()
    {
        var listString = new List<string>();
        var dictStringInt = new Dictionary<string, int>();
        var dictStringString = new Dictionary<string, string>();
        var dictStringDict = new Dictionary<string, Dictionary<string, int>>();
        var listDict = new List<Dictionary<string, int>>();
        var listChoice = new List<Datecraft.Data.Choice>();
        var listResponse = new List<Datecraft.Data.Response>();
        var listSubLocation = new List<Datecraft.Data.SubLocation>();
        var listSuccessThreshold = new List<Datecraft.Data.SuccessThreshold>();
        Debug.Log("AOT Helper initialized for Json.NET collections");
    }
}