using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private int _health = 3;
    private int coinCounter = 0;
    public string nextLevel = "Geo_Quest_Scene_1 1";
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Health":
                {
                    _health++;
                    Destroy(collision.gameObject);
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
