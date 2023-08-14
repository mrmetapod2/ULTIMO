using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformscript : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints for platform movement
    public float speed = 2.0f; // Movement speed of the platform

    private int currentWaypoint = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (waypoints.Length == 0)
            return;

        // Move towards the current waypoint
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);

        // Check if the platform has reached the current waypoint
        if (Vector2.Distance(transform.position, waypoints[currentWaypoint].position) < 0.1f)
        {
            // Move to the next waypoint
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length;
    }
}
}