using UnityEngine;

public class BallScaleSetting : MonoBehaviour
{
    private void Update()
    {
        // Set the ball scale to the given value
        transform.localScale = Vector3.one * Settings.BallSize;
    }
}
