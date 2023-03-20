using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float velocity;

    private void Update()
    {
        float y = Mathf.SmoothDampAngle(transform.rotation.eulerAngles.y, target.rotation.eulerAngles.y, ref velocity, Time.smoothDeltaTime, PlayerPrefs.GetFloat("TurnSpeed", 10));

        transform.rotation = Quaternion.Euler(0, y, 0);

        transform.position = new Vector3(target.position.x, 0, target.position.z);
    }
}
