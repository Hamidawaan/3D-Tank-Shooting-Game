using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
   // public GameObject enemy;
    public float life = 3f;
    public int enemiesRemaining = 5; // The number of enemies remaining
    public Text winText ; // The UI text element to display the win message
    // Whether the game is over
    
    void Awake()
    {
        Destroy(gameObject, life);
        winText = GetComponent<Text>();
        winText.enabled = false;


    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            EnemyDestroyed();
            Debug.Log("Enemy is collided ");
        }
    }


   
   

    void Update()
    {
        // If there are no enemies remaining and the game is not over, show the win message
        if (enemiesRemaining == 0)
        {
            winText.text = "You win!";
            winText.enabled = true;
            Debug.Log("You win");
            
        }
    }

    // This function is called when an enemy is destroyed
    public void EnemyDestroyed()
    {
        enemiesRemaining--; // Decrement the enemy count
    }
}
