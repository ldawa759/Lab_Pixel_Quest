using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GeoController : MonoBehaviour
{
    string variable1 = "Hello ";
    int var = 3;
    private Rigidbody2D rb;
    public int speed = 5;

    // Start is called before the first frame update
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        string variable2 = "World";
        Debug.Log(variable1 + variable2);
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        //Debug.Log(xSpeed);
        rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);

        /*
       if (Input.GetKeyDown(KeyCode.W))
        {transform.position += new Vector3(0, 1, 0); }
       if (Input.GetKeyDown(KeyCode.S))
        { transform.position += new Vector3(0, -1, 0); }
       if (Input.GetKeyDown(KeyCode.A))
        { transform.position += new Vector3(-1, 0, 0); }
        if (Input.GetKeyDown(KeyCode.D))
        { transform.position += new Vector3(1, 0, 0); }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

    }


}
