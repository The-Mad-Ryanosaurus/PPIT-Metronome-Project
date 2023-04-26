using Microsoft.MixedReality.Toolkit.Input;

using UnityEngine;

public class SettingDefaults : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    [SerializeField] private float clickSpeed = 1;

    private float timer = 0f;
    private int clicks = 0;
    private GameObject cursor;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Distance") == false)
        {
            PlayerPrefs.SetFloat("Distance", 1.25f);
        }

        if (PlayerPrefs.HasKey("Height") == false)
        {
            PlayerPrefs.SetFloat("Height", 0f);
        }

        if (PlayerPrefs.HasKey("Color") == false)
        {
            PlayerPrefs.SetString("Color", "Green");
        }

        if (PlayerPrefs.HasKey("BallSize") == false)
        {
            PlayerPrefs.SetFloat("BallSize", .5f);
        }

        if (PlayerPrefs.HasKey("Speed") == false)
        {
            PlayerPrefs.SetFloat("Speed", 1f);
        }

        if (PlayerPrefs.HasKey("TrackSpeed") == false)
        {
            PlayerPrefs.SetFloat("TrackSpeed", 5f);
        }
    }

    private void Start()
    {
        Invoke(nameof(GetCursor), 1);
    }

    private void GetCursor()
    {
        cursor = FindObjectOfType<AnimatedCursor>().gameObject;
    }

    public void Click()
    {
        clicks++;
    }

    private void Update()
    {
        if (clicks == 1 && timer == 0)
        {
            timer = Time.time;
        }

        cursor?.SetActive(settings.activeSelf);

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
