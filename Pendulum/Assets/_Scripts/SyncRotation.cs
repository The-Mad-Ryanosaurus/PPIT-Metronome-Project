using UnityEngine;

public class SyncRotation : MonoBehaviour
{
    [SerializeField] private Transform gyro;

    private void Update()
    {
        transform.localRotation = gyro.rotation;
    }
}
