using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MFlight : MonoBehaviour
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
            if (isTouchInputDetected())
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
            MSceneController.instance.GameOver();
        }
    
    private bool isTouchInputDetected()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) 
        {
            return true;
        }
        return false;
    }

}
