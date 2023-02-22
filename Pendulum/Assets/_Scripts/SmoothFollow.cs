using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform target;
    [SerializeField] private Transform cameraRig;

    private Vector3 velocity;

    private void Awake()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }

    private void Update()
    {

        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, Time.smoothDeltaTime, speed);
        transform.rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
    }
}
