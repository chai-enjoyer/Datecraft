using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Datecraft.Data;

namespace Datecraft.Data // Changed namespace to match data models
{
    public class DataManager : MonoBehaviour
    {
        // Singleton instance
        public static DataManager Instance { get; private set; }

        // Data collections
        public List<Character> Characters { get; private set; } = new List<Character>();
        public List<Datecraft.Data.Event> Events { get; private set; } = new List<Datecraft.Data.Event>(); // Explicitly qualify Event
        public List<Location> Locations { get; private set; } = new List<Location>();
        public List<CosmeticData> Cosmetics { get; private set; } = new List<CosmeticData>();
        public GameData GameData { get; private set; }

        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore
        };

        private void Awake()
        {
            // Ensure singleton
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                LoadAllData();
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void LoadAllData()
        {
            string dataPath = Path.Combine(Application.dataPath, "Data");
            LoadCharacters(Path.Combine(dataPath, "Characters"));
            LoadEvents(Path.Combine(dataPath, "Cards"));
            LoadLocations(Path.Combine(dataPath, "Locations")); // Fixed to "Locations"
            LoadCosmetics(Path.Combine(dataPath, "Cosmetics"));
            LoadGameData(Path.Combine(dataPath, "game_data.json"));
        }

        private void LoadCharacters(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Debug.LogError($"Characters directory not found: {folderPath}");
                return;
            }

            foreach (string filePath in Directory.GetFiles(folderPath, "*.json"))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    Character character = JsonConvert.DeserializeObject<Character>(json, _settings);
                    if (character != null)
                    {
                        Characters.Add(character);
                        Debug.Log($"Loaded character: {character.Name} from {filePath}");
                    }
                }
                catch (System.Exception ex)
                {
                    Debug.LogError($"Failed to load character from {filePath}: {ex.Message}");
                }
            }
        }

        private void LoadEvents(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Debug.LogError($"Cards directory not found: {folderPath}");
                return;
            }

            foreach (string filePath in Directory.GetFiles(folderPath, "*.json"))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    Datecraft.Data.Event evt = JsonConvert.DeserializeObject<Datecraft.Data.Event>(json, _settings); // Explicitly qualify Event
                    if (evt != null)
                    {
                        Events.Add(evt);
                        Debug.Log($"Loaded event: {evt.Id} from {filePath}");
                    }
                }
                catch (System.Exception ex)
                {
                    Debug.LogError($"Failed to load event from {filePath}: {ex.Message}");
                }
            }
        }

        private void LoadLocations(string folderPath) // Fixed parameter type to string
        {
            if (!Directory.Exists(folderPath))
            {
                Debug.LogError($"Locations directory not found: {folderPath}");
                return;
            }

            foreach (string filePath in Directory.GetFiles(folderPath, "*.json"))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    Location location = JsonConvert.DeserializeObject<Location>(json, _settings);
                    if (location != null)
                    {
                        Locations.Add(location);
                        Debug.Log($"Loaded location: {location.Name} from {filePath}");
                    }
                }
                catch (System.Exception ex)
                {
                    Debug.LogError($"Failed to load location from {filePath}: {ex.Message}");
                }
            }
        }

        private void LoadCosmetics(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Debug.LogError($"Cosmetics directory not found: {folderPath}");
                return;
            }

            foreach (string filePath in Directory.GetFiles(folderPath, "*.json"))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    CosmeticData cosmetic = JsonConvert.DeserializeObject<CosmeticData>(json, _settings); // Fixed syntax
                    if (cosmetic != null)
                    {
                        Cosmetics.Add(cosmetic);
                        Debug.Log($"Loaded cosmetic: {cosmetic.Name} from {filePath}");
                    }
                }
                catch (System.Exception ex)
                {
                    Debug.LogError($"Failed to load cosmetic from {filePath}: {ex.Message}");
                }
            }
        }

        private void LoadGameData(string filePath) // Ensured non-static
        {
            if (!File.Exists(filePath))
            {
                Debug.LogError($"GameData file not found: {filePath}");
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                GameData = JsonConvert.DeserializeObject<GameData>(json, _settings);
                if (GameData != null)
                {
                    Debug.Log($"Loaded game data from {filePath}");
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"Failed to load game data from {filePath}: {ex.Message}");
            }
        }
    }
}