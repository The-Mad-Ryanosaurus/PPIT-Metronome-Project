using Newtonsoft.Json;

using UnityEngine;

public class Settings : MonoSingleton<Settings>
{
    public Config Json = new();

    public static float Frequency => I.Json.Frequency;
    public static float Distance => I.Json.Distance;
    public static float Height => I.Json.Height;
    public static float BallSize => I.Json.BallSize;

    private void Awake()
    {
        // Load the settings from the JSON file
        LoadSettings();

        // Save the settings to the JSON file every minute incase of crash
        InvokeRepeating(nameof(SaveSettings), 60f, 60f);
    }

    private void OnApplicationQuit()
    {
        // Save the settings to the JSON file when the application quits
        SaveSettings();
    }

    private void LoadSettings()
    {
        // Load settings from android persistent data path
#if !UNITY_EDITOR
        string path = Application.persistentDataPath + "/settings.json";
#else
        string path = Application.dataPath + "/settings.json";
#endif

        // If the file exists, load the settings
        if (System.IO.File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            I.Json = JsonConvert.DeserializeObject<Config>(json);
        }
        else
        {
            // If the file doesn't exist, create it
            SaveSettings();
        }
    }

    private void SaveSettings()
    {
        // Save settings to android persistent data path
#if !UNITY_EDITOR
        string path = Application.persistentDataPath + "/settings.json";
#else
        string path = Application.dataPath + "/settings.json";
#endif

        // Save the settings to the file
        string json = JsonConvert.SerializeObject(I.Json, Formatting.Indented);
        System.IO.File.WriteAllText(path, json);
    }
}

public class Config
{
    public float Frequency = 1f;
    public float Distance = 10f;
    public float Height = 5f;
    public float BallSize = .5f;
}
