using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingText : MonoBehaviour
{
    [SerializeField] private string settingName;

    private void Update()
    {
        GetComponent<TMPro.TMP_Text>().text = PlayerPrefs.GetFloat(settingName).ToString("0.00");
    }
}
