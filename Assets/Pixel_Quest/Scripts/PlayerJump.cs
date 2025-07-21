using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float JumpForce = 10f;
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;

    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            rb.velocity = new Vector2(rb.velocity.x, JumpForce); 
        }
    }
}
