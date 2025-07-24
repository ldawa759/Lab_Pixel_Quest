using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Image Heart;
    // Start is called before the first frame update
    private void Start()
    {
      Heart = GameObject.Find("HeartImage").GetComponent<Image>();
    }

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        Heart.fillAmount = currentHealth / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
