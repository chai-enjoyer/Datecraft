using UnityEngine;
using Datecraft.Data;

public class TestDataManager : MonoBehaviour
{
    void Start()
    {
        if (DataManager.Instance == null)
        {
            Debug.LogError("DataManager not found!");
            return;
        }

        // Test Characters
        foreach (var character in DataManager.Instance.Characters)
        {
            Debug.Log($"Character: {character.Name}, ID: {character.Id}");
        }

        // Test Events
        foreach (var evt in DataManager.Instance.Events)
        {
            Debug.Log($"Event: {evt.Id}, Text: {evt.Text}");
        }

        // Test Locations
        foreach (var location in DataManager.Instance.Locations)
        {
            Debug.Log($"Location: {location.Name}, ID: {location.Id}");
        }

        // Test Cosmetics
        foreach (var cosmetic in DataManager.Instance.Cosmetics)
        {
            Debug.Log($"Cosmetic: {cosmetic.Name}, ID: {cosmetic.Id}");
        }

        // Test GameData
        if (DataManager.Instance.GameData != null)
        {
            foreach (var threshold in DataManager.Instance.GameData.SuccessThresholds)
            {
                Debug.Log($"GameData Threshold: {threshold.Parameter}={threshold.Value}");
            }
        }
    }
}