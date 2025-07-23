using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int _health = 3;
    private int coinCounter = 0;
    public string nextLevel = "Geo_Quest_Scene_1 1";
    public Transform RespawnPoint;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Respawn":
                {
                    RespawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }
            case "Health":
                {
                    if (_health < 3)
                    {
                        _health++;
                        Destroy(collision.gameObject);
                    }


                    break;
                }
                

            case "Coin": 
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;

                }

            case "Death":
                {
                    //string thisLevel = SceneManager.GetActiveScene().name;
                    //SceneManager.LoadScene(thisLevel);
                    //Debug.Log("Player Has Died");
                    _health--;
                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = RespawnPoint.position;
                    }
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
