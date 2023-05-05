using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    private Transform[] pathPoints;
    private float speed;
    private int currentPoint = 0;

    public void SetPathPoints(Transform[] points, float moveSpeed)
    {
        pathPoints = points;
        speed = moveSpeed;
    }

    private void Update()
    {
        if (currentPoint < pathPoints.Length)
        {
            // Move towards the next point
            transform.position = Vector2.MoveTowards(transform.position, pathPoints[currentPoint].position, speed * Time.deltaTime);

            // Check if reached the next point
            if (transform.position == pathPoints[currentPoint].position)
            {
                currentPoint++;
            }
        }
        else
        {
            // Destroy object when reached the end of the path
            Destroy(gameObject);
        }
    }
}
