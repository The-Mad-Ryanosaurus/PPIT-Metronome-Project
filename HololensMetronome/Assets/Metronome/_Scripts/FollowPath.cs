using UnityEngine;

public class FollowPath : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;

    [SerializeField] private Transform ball;

    [Header("Match the curve model")]
    [SerializeField] private AnimationCurve curve;

    private float timer = 0;

    private void Update()
    {
        // Update the timer for lerping at the given frequency
        timer += Time.deltaTime * PlayerPrefs.GetFloat("Speed", .5f);

        // PingPong will return a value between 0 and 1
        float t = Mathf.PingPong(timer, 1f);

        // Lerp between the start and end positions
        ball.position = Vector3.Lerp(start.position, end.position, t);

        const float curveHeight = 0.08f;

        // Move the ball up and down based on the curve
        ball.position += new Vector3(0, curve.Evaluate(t) * curveHeight, 0);
    }
}
