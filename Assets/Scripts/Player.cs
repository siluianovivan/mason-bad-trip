using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _rb;
    private Vector2 moveVelocity;

    private bool isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Activate()
    {
        _rb.isKinematic = false;
    }

    void Update()
    {
        if (isGrounded)
        {
            Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
            moveVelocity = moveInput * speed;
        }
    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            _rb.MovePosition(_rb.position + moveVelocity * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            isGrounded = true;
        }
    }
}
