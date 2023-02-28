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
        "Field Of View",
        "Turn Speed",
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
        Settings.Frequency = DisplaySetting(Settings.Frequency, 0, 0.1f);
        Settings.Distance = DisplaySetting(Settings.Distance, 1, 0.5f);
        Settings.Height = DisplaySetting(Settings.Height, 2, 0.2f);
        Settings.BallSize = DisplaySetting(Settings.BallSize, 3, 0.1f);
        Settings.FieldOfView = DisplaySetting(Settings.FieldOfView, 4, 1f);
        Settings.TurnSpeed = DisplaySetting(Settings.TurnSpeed, 5, 2f);
    }

    private float DisplaySetting(float setting, int index, float step)
    {
        if (currentSetting == index)
        {
            // Display the current setting
            text.text = settings[currentSetting] + ": " + MathF.Round(setting, 1);

            // Change the setting with the up and down arrow keys by the given step
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                return setting + step;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                return setting - step;
            }
        }

        return setting;
    }
}
