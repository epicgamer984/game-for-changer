using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliaion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Do whatever you want when the player collects the object
            // For example, increase score or play a sound
            Debug.Log("Player collected the object!");

            // Destroy the collectable object upon contact with the player
            Destroy(gameObject);
        }
    }
}
