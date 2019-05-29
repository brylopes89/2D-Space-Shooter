using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour {

    public int currentScore;
    public Text scoreText;

	// Use this for initialization
	void Start ()
    {
        UIUpdate();
	}

    public void UIUpdate()
    {
        scoreText.text = "Score: " + currentScore.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
