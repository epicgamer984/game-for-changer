using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f; // Speed at which the enemy moves
     // Flag to track if the player is in range

    void Update()
    {
        
        
    }

    // Method to move the enemy off-screen
    void MoveOffScreen()
    {
        // Calculate direction to move off-screen (for example, move to the right)
        Vector3 direction = Vector3.right;

        // Move the enemy off-screen
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // Method called when the enemy collides with another collider
 

    // Method called when the enemy is no longer colliding with another collider
   
}