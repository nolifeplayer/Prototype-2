using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float topBound = 30;
    private float lowerBound = -15;
    private float leftBound = -23;
    private float rightBound = 23;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {                                                                                                                    
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }

        if (transform.position.x < leftBound)
        {
        Destroy(gameObject);
        }

        if (transform.position. x > rightBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
