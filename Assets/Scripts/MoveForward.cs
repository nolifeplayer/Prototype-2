using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
    if (other.CompareTag("Enemy")) // Ensure your animal has the "Animal" tag
    {
        // Find the ScoreManager and increase score
        FindObjectOfType<ScoreManager>().IncreaseScore(1);
        
        // Remove the food after feeding
        Destroy(gameObject); 
        
    }

    }
}
