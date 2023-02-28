using UnityEngine;

public class Settings
{
    public static float FieldOfView;
    public static float Frequency;
    public static float Distance;
    public static float BallSize;
    public static float Height;
    public static float TurnSpeed;

    public static void Load()
    {
        FieldOfView = PlayerPrefs.GetFloat("FieldOfView", 40f);
        Frequency = PlayerPrefs.GetFloat("Frequency", 1f);
        Distance = PlayerPrefs.GetFloat("Distance", 10f);
        BallSize = PlayerPrefs.GetFloat("BallSize", .5f);
        Height = PlayerPrefs.GetFloat("Height", 5f);
        TurnSpeed = PlayerPrefs.GetFloat("TurnSpeed", 10f);
    }

    public static void Save()
    {
        PlayerPrefs.SetFloat("FieldOfView", FieldOfView);
        PlayerPrefs.SetFloat("Frequency", Frequency);
        PlayerPrefs.SetFloat("Distance", Distance);
        PlayerPrefs.SetFloat("BallSize", BallSize);
        PlayerPrefs.SetFloat("Height", Height);
        PlayerPrefs.SetFloat("TurnSpeed", TurnSpeed);
    }
}
