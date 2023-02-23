using System;

using TMPro;

using UnityEngine;

public class SettingsSeletor : MonoBehaviour
{
    private string[] settings = {
        "Frequency",
        "Distance",
        "Height",
        "Ball Size",
    };
    private int currentSetting = 0;

    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        // Cycle through the settings
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentSetting++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentSetting--;
        }

        // Clamp the current setting to the array length
        if (currentSetting < 0)
        {
            currentSetting = settings.Length - 1;
        }
        else if (currentSetting >= settings.Length)
        {
            currentSetting = 0;
        }

        // Display the current setting
        DisplaySetting(ref Settings.I.Json.Frequency, 0, 0.1f);
        DisplaySetting(ref Settings.I.Json.Distance, 1, 0.5f);
        DisplaySetting(ref Settings.I.Json.Height, 2, 0.5f);
        DisplaySetting(ref Settings.I.Json.BallSize, 3, 0.1f);
    }

    private void DisplaySetting(ref float setting, int index, float step)
    {
        if (currentSetting == index)
        {
            // Display the current setting
            text.text = settings[currentSetting] + ": " + MathF.Round(setting, 1);

            // Change the setting with the up and down arrow keys by the given step
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                setting += step;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                setting -= step;
            }
        }
    }
}
