using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int _maxHealth = 3;
    public int _health = 3;
    private int coinCounter = 0;
    private int coinsInLevel = 0;
    public Transform RespawnPoint;
    private PlayerUIController _playerUIController;

    public void Start()
    {
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
        _playerUIController = GetComponent<PlayerUIController>();
        _playerUIController.UpdateHealth(_health, _maxHealth);
        _playerUIController.UpdateCoin(coinCounter + "/" + coinsInLevel);
    }

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
                        _playerUIController.UpdateHealth(_health, _maxHealth);
                        Destroy(collision.gameObject);
                    }


                    break;
                }
                

            case "Coin": 
                {
                    coinCounter++;
                    _playerUIController.UpdateCoin(coinCounter + "/" + coinsInLevel);
                    Destroy(collision.gameObject);
                    break;

                }

            case "Death":
                {
                    //string thisLevel = SceneManager.GetActiveScene().name;
                    //SceneManager.LoadScene(thisLevel);
                    //Debug.Log("Player Has Died");
                    _health--;
                    _playerUIController.UpdateHealth(_health, _maxHealth);
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
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
