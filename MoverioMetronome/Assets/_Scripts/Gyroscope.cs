using UnityEngine;

public class Gyroscope : MonoBehaviour
{
    private void Start()
    {
        // Enable the gyro
        Input.gyro.enabled = true;

        // Set the gyro polling rate to 100 per second
        Input.gyro.updateInterval = 0.01f;
    }

    private void Update()
    {
        // Get the raw quaternion angle from the gyro
        Quaternion rawRotation = Input.gyro.attitude;

        // Convert the quaternion to euler angles eg yaw pitch and roll
        Vector3 eulerRawRotation = rawRotation.eulerAngles;

        // Invert the pitch and yaw
        transform.localRotation = Quaternion.Euler(90, 0, 0) * Quaternion.Euler(-eulerRawRotation.x, -eulerRawRotation.y, eulerRawRotation.z);
    }
}
