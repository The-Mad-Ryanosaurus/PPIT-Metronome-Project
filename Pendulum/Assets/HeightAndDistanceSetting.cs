using UnityEngine;

public class HeightAndDistanceSetting : MonoBehaviour
{
    private void Update()
    {
        transform.localPosition = new(0, Settings.Height, Settings.Distance);
    }
}
