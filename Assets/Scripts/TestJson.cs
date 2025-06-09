using UnityEngine;
using Newtonsoft.Json;
using Datecraft.Data;
using System.IO;

public class TestJson : MonoBehaviour
{
    void Start()
    {
        string path = Path.Combine(Application.dataPath, "Data/Characters/test.json");
        Debug.Log($"Attempting to load JSON from: {path}");
        try
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                Debug.Log($"JSON content: {json}");
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore
                };
                Character character = JsonConvert.DeserializeObject<Character>(json, settings);
                Debug.Log($"Loaded character: {character.Name}, Emotion: {character.EmotionState}");
                Debug.Log($"Initial Parameters: R={character.InitialParameters["R"]}, F={character.InitialParameters["F"]}");
                Debug.Log($"Card Foreground (happy): {character.CardForeground["happy"]}");
                Debug.Log($"Emotion Effects (happy, R): {character.EmotionEffects["happy"]["R"]}");
            }
            else
            {
                Debug.LogError($"JSON file not found at: {path}");
            }
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"JSON deserialization failed: {ex.Message}\nStackTrace: {ex.StackTrace}");
        }
    }
}