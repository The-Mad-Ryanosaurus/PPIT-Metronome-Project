using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSetting : MonoBehaviour
{
    [SerializeField] private string settingName;

    private void Start()
    {
        GetComponent<Slider>().value = PlayerPrefs.GetFloat(settingName, 0.5f);
    }

    public void ChangeValue(float value)
    {
        PlayerPrefs.SetFloat(settingName, value);
    }
}
