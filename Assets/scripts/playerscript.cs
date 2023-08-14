using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public CircleCollider2D circleCollider1;
    public CircleCollider2D circleCollider2;
    private Collider2D platform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (circleCollider1.IsTouchingLayers()) // You can add a specific layer mask here if needed
        {
            
        }

        // Check for interactions with Circle Collider 2
        if (circleCollider2.IsTouchingLayers()) // You can add a specific layer mask here if needed
        {
            
        }

        // Check for overlap between the two colliders (you can modify this condition)
        if (circleCollider1.bounds.Intersects(circleCollider2.bounds))
        {
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.GetType());
        if (other.tag == "MOVE PLAT")
        {
            platform=other;
        }
        else if (other == circleCollider2)
        {
            Debug.Log("Entered Collider 2");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other == circleCollider1)
        {
            Debug.Log("Exited Collider 1");
        }
        else if (other == circleCollider2)
        {
            Debug.Log("Exited Collider 2");
        }
    }
    
}
