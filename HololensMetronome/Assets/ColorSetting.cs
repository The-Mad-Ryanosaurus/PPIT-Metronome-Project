using UnityEngine;

public class ColorSetting : MonoBehaviour
{
    public void SetColor(string color)
    {
        PlayerPrefs.SetString("Color", color);
    }
}
