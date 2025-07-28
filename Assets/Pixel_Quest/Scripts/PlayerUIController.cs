using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PlayerUIController : MonoBehaviour
{
    public Image Heart;
    public TextMeshProUGUI coinText;

    // Start is called before the first frame update
    private void Start()
    {
      Heart = GameObject.Find("HeartImage").GetComponent<Image>();
        coinText = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
    }

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        Heart.fillAmount = currentHealth / maxHealth;
    }

    public void UpdateCoin(string newText)
    {
        coinText.text = newText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
