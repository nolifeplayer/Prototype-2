using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; // Needed for UI elements
using UnityEngine.SceneManagement; // Needed to restart scene

public class PlayerHealth : MonoBehaviour

{
    
    public int lives = 3;
    public Text livesText; // Drag your UI Text here
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Call this method when a hit occurs
    public void TakeDamage()
    {
        lives--; // Decrease life
        UpdateUI();

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            // Add Game Over logic here (e.g., Load Scene)
        }
    }

    void UpdateUI()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }
}
