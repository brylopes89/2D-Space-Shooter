using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

    private ScoreHolder scoreHolderReference;

    void OnCollisionEnter2D(Collision2D collider)         
    {
        if(collider.gameObject.tag == "Enemy")
        {
            Destroy(collider.gameObject);

            scoreHolderReference = GameObject.Find("GameController").GetComponent<ScoreHolder>();

            scoreHolderReference.currentScore++;

            scoreHolderReference.UIUpdate();

            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
