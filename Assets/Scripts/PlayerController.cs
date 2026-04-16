using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
        public GameObject projectilePrefab;
        public float horizontalInput;
        public float verticalInput;
        public float speed = 30.0f;
        public float xRange = 20;
        public float zRange = 30;
    // Update is called once per frame
    void Update()
    {   // Keep the player in bounds
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
            {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
         verticalInput = Input.GetAxis("Vertical");
         transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

         if(transform.position.z < -zRange) 
            {
            transform.position = new Vector3(-zRange, transform.position.y, transform.position.z);
            }
        if (transform.position.z> zRange)
            {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.z);
            }

        

    }
}
