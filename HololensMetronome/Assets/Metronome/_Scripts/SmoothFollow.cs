using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float velocity;

    private void LateUpdate()
    {
        float currentAngle = transform.rotation.eulerAngles.y;
        float targetAngle = target.rotation.eulerAngles.y;

        transform.rotation = Quaternion.Euler(
            0,
            Mathf.LerpAngle(currentAngle, targetAngle, Time.deltaTime),
            0
        );

        transform.position = new Vector3(target.position.x, 0, target.position.z);
    }
}
