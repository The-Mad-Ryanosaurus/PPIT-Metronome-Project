using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingDefaults : MonoBehaviour
{
    [SerializeField] private GameObject settings;

    [SerializeField] float clickSpeed = 1;

    float timer = 0f;

    int clicks = 0;

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

    public void Click()
    {
        clicks++;
    }

    void Update()
    {
        if (clicks == 1 && timer == 0)
        {
            timer = Time.time;
        }

        if (clicks == 3)
        {
            if (Time.time - timer <= clickSpeed)
            {
                if (settings && settings.activeSelf == false)
                {
                    settings.SetActive(true);
                }
            }

            timer = 0;
            clicks = 0;
        }


        if (Time.time - timer > clickSpeed)
        {
            timer = 0;
            clicks = 0;
        }

    }

}
