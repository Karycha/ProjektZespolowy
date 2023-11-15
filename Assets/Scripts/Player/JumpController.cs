using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class JumpController : MonoBehaviour
{
    public float jumpForce = 10f;
    public LayerMask groundLayer;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.1f, groundLayer);
    }
}
