using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GeoController : MonoBehaviour
{
    string variable1 = "Hello ";
    int var = 3;
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Geo_Quest_Scene_1 1";
    public int height = 4;
    private SpriteRenderer sr;
    // Start is called before the first frame update
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        string variable2 = "World";
        Debug.Log(variable1 + variable2);
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        //Debug.Log(xSpeed);
        rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        { sr.color = Color.yellow; }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        { sr.color = Color.red; }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        { sr.color = Color.blue; }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, height);
        }
       /*if (Input.GetKeyDown(KeyCode.W))
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
        switch (collision.tag)
        { 
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    Debug.Log("Player Has Died"); 
                  break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
   


}
