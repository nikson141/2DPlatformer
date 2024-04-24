using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private GameObject[] platformWayPoints;
    [SerializeField] private float platformSpeed;

    private int _currentPlatformWayPointIndex;
    private Transform _parentObject;

    private void Update()
    {
        MoveBetweenWaypoints();
    }

    private void MoveBetweenWaypoints()
    {
        if (Vector2.Distance(platformWayPoints[_currentPlatformWayPointIndex].transform.position, transform.position) < .1f)
        {
            _currentPlatformWayPointIndex++;
            if (_currentPlatformWayPointIndex >= platformWayPoints.Length)
            {
                _currentPlatformWayPointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, platformWayPoints[_currentPlatformWayPointIndex].transform.position, platformSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _parentObject = transform;
        other.transform.parent = _parentObject;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        other.transform.parent = null;
    }
}
