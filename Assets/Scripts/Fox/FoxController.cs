using UnityEngine;

public class FoxController : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    [SerializeField] private float speed;

    private int _currentWayPointIndex;
    private bool _isFacingRight = true; // Assuming the fox starts facing right

    private void Update()
    {
        MoveBetweenWaypoints();
        FlipFox();
    }

    private void MoveBetweenWaypoints()
    {
        if (Vector2.Distance(wayPoints[_currentWayPointIndex].transform.position, transform.position) < .1f)
        {
            _currentWayPointIndex++;
            if (_currentWayPointIndex >= wayPoints.Length)
            {
                _currentWayPointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, wayPoints[_currentWayPointIndex].transform.position, speed * Time.deltaTime);
    }

    private void FlipFox()
    {
        // Determine the "horizontal input" based on the direction to the next waypoint
        float directionToWaypoint = wayPoints[_currentWayPointIndex].transform.position.x - transform.position.x;

        // Flip conditions based on direction and facing
        if ((_isFacingRight && directionToWaypoint < 0f) || (!_isFacingRight && directionToWaypoint > 0f))
        {
            _isFacingRight = !_isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }
}
