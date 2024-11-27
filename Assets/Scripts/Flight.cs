using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flight : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] float velocity = 1.5f;
    [SerializeField] float rotationSpeed = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame || Gamepad.current.buttonSouth.wasPressedThisFrame)
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneController.instance.GameOver();
    }
}
