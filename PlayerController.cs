using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 100f; // Adjust the rotation speed as needed
    private Rigidbody2D rb;
     public float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input for rotation
        float rotationInput = Input.GetAxis("Horizontal");

        // Rotate the player
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotationAmount);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}