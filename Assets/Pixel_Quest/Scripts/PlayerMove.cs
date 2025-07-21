using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        //Debug.Log(xSpeed);
        rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);

        if (xSpeed > 0)
        {
            sr.flipX = true;
        }
        else if (xSpeed < 0)
        {
            sr.flipX = false;
        }
    }
}
