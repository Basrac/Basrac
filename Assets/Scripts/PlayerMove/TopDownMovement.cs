using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private bool isJumping = false;
    private bool isGrounded = true;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _controller.CallJumpEvent();
        }

        if (isJumping && isGrounded)
        {
            _controller.CallLandEvent();
            isJumping = false;
        }
    }

    private void FixedUpdate()
    {
        isGrounded = IsGrounded(); 
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }

    private void Jump()
    {
        if (isGrounded)
        {
            float jumpForce = 10.0f;
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpForce);
            _controller.CallJumpEvent();
            isJumping = true;
        }
    }

    private bool IsGrounded()
    {
        float circleRadius = 0.1f;
        Vector2 circleCenter = transform.position - new Vector3(0, GetComponent<Collider2D>().bounds.extents.y);
        Collider2D hitCollider = Physics2D.OverlapCircle(circleCenter, circleRadius);
        return (hitCollider != null && hitCollider.gameObject != gameObject);
    }    
}