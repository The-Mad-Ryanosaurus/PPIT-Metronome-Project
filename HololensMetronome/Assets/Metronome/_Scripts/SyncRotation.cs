using UnityEngine;

public class SyncRotation : MonoBehaviour
{
    [SerializeField] private Transform gyro;

    private void LateUpdate()
    {
        transform.localRotation = gyro.rotation;
    }
}
