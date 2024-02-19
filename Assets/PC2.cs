using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PC2 : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15;
    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Use J and L for horizontal movement instead of Horizontal axis
        float hInput = Input.GetKey(KeyCode.L) ? 1 : Input.GetKey(KeyCode.J) ? -1 : 0;

        // Use I for forward movement instead of Vertical axis
        float vInput = Input.GetKey(KeyCode.I) ? 1 : 0;

        // Apply movement based on inputs
        if (characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * rotationSpeed * hInput;

            // Jump on K press
            if (Input.GetKeyDown(KeyCode.K))
            {
                moveVelocity.y = jumpSpeed;
            }
        }

        // Add gravity and move the character
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
}
