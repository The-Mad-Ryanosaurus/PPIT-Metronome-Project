using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingDefaults : MonoBehaviour
{
    void Awake()
    {
        if (PlayerPrefs.HasKey("Distance") == false)
        {
            PlayerPrefs.SetFloat("Distance", 1.25f);
        }

        if (PlayerPrefs.HasKey("Height") == false)
        {
            PlayerPrefs.SetFloat("Height", 0f);
        }

        if (PlayerPrefs.HasKey("BallSize") == false)
        {
            PlayerPrefs.SetFloat("BallSize", .5f);
        }

        if (PlayerPrefs.HasKey("Speed") == false)
        {
            PlayerPrefs.SetFloat("Speed", 1f);
        }
    }
}
