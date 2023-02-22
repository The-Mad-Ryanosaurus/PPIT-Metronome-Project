using UnityEngine;

public class FollowPath : MonoBehaviour
{
    [SerializeField, Range(0f, .1f)] private float speed;

    [SerializeField] private Transform ball;
    [SerializeField] private Transform[] path;

    private int currentPoint = 0;

    private void Start()
    {
        // Start the ball at the first position in the path
        ball.position = path[currentPoint].position;

        // Set the target to the next point in the path
        currentPoint++;
    }

    private void Update()
    {
        // Bounce the vale from the start of the the path to the end without looping
        int pingpongedPoint = (int)Mathf.PingPong(currentPoint, path.Length - 1);

        // Move the ball to the next target position
        ball.position = Vector3.MoveTowards(ball.position, target: path[pingpongedPoint].position, speed);

        // If the ball is within the very small range increse the current point variable
        // to start the ball moving towards the next point in th apth
        if (Vector3.Magnitude(ball.position - path[pingpongedPoint].position) < 0.001f)
        {
            // Increase the index in the path
            currentPoint++;
        }
    }
}
