using UnityEngine;

public class HeightAndDistanceSetting : MonoBehaviour
{
    private void Update()
    {
        transform.localPosition = new Vector3(0, PlayerPrefs.GetFloat("Height"), PlayerPrefs.GetFloat("Distance"));
    }
}
