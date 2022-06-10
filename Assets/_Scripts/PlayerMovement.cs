using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public Transform groudCheck;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    Vector3 velocity;
    bool isGrounded;
    public ParticleSystem _particleSystem;


    void Update()
    {
        isGrounded = Physics.CheckSphere(groudCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }
}
