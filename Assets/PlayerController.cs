using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpForce = 10f;

    private Rigidbody2D rb;

    [SerializeField] Transform groundCheck;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayer;

    [ReadOnly] [SerializeField] bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        float input = Input.GetAxis("Horizontal") * moveSpeed;
        Vector2 movement = new Vector2(input, 0);
        movement.y = rb.velocity.y;
        rb.velocity = movement;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0, Physics2D.gravity.y < 0 ? jumpForce : -jumpForce));
        }
    }
}
