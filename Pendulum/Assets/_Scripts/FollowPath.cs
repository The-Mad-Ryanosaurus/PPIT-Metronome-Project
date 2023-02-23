using UnityEngine;

public class FollowPath : MonoBehaviour
{
    [SerializeField, Range(0.1f, 5f)] private float frequency = 0.5f;

    [SerializeField] private Transform start;
    [SerializeField] private Transform end;

    [SerializeField] private Transform ball;

    [Header("Match the curve model")]
    [SerializeField] private AnimationCurve curve;

    private float timer = 0;

    private void Start()
    {
    }

    private void Update()
    {
        timer += Time.deltaTime * frequency;

        float t = Mathf.PingPong(timer, 1f);

        ball.position = Vector3.Lerp(start.position, end.position, t);
        ball.position += new Vector3(0, curve.Evaluate(t) * 0.8f, 0);
    }
}
