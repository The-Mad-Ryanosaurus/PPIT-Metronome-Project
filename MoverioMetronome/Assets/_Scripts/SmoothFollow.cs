using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float velocity;

    private void Update()
    {
        float y = Mathf.SmoothDampAngle(transform.rotation.eulerAngles.y, target.rotation.eulerAngles.y, ref velocity, Time.smoothDeltaTime, Settings.TurnSpeed);

        transform.rotation = Quaternion.Euler(0, y, 0);
    }
}
