using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSetting : MonoBehaviour
{
    [SerializeField] private string settingName;

    public void ChangeValue(float value)
    {
        PlayerPrefs.SetFloat(settingName, value);
    }

    private void Update()
    {
        GetComponent<Slider>().value = PlayerPrefs.GetFloat(settingName);
    }
}
