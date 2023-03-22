using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float velocity;

    private void Update()
    {
        float currentAngle = transform.rotation.eulerAngles.y;
        float targetAngle = target.rotation.eulerAngles.y;

        float delta = Mathf.Abs(currentAngle - targetAngle);

        float y = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref velocity, Time.smoothDeltaTime, delta * 3);

        transform.rotation = Quaternion.Euler(0, y, 0);

        transform.position = new Vector3(target.position.x, 0, target.position.z);
    }
}
