using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float JumpForce = 10f;
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
