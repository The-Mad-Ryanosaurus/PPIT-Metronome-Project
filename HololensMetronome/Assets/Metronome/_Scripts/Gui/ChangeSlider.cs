using UnityEngine;

public class ChangeSlider : MonoBehaviour
{
    [SerializeField] private string settingName;

    [SerializeField] private float value;

    public void Click()
    {
        float val = PlayerPrefs.GetFloat(settingName) + value;

        if (val < 0)
        {
            val = 0;
        }

        PlayerPrefs.SetFloat(settingName, val);
    }
}
