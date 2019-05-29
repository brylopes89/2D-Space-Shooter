using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour {

    public int health;
    public Text healthText;
    public GameObject gameOverCanvas;

	// Use this for initialization
	void Start ()
    {

        UpdateHealthUI();
        gameOverCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            health--;
            UpdateHealthUI();
        
    
        }

        if (health <= 0)
        {
            gameOverCanvas.SetActive(true);
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D objectThatHitMe)
    {
        if(objectThatHitMe.gameObject.tag == "Enemy")
        {
            health--;
            UpdateHealthUI();
            print("I hit something and my health is " + health);

            
        }
    }

    void UpdateHealthUI()
    {
        healthText.text = "Health: " + health.ToString();
    }
}
