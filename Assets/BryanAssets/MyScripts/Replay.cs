using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

    public void RestartGame(string CurrentScene)
    {
        SceneManager.LoadScene(CurrentScene);
    }

	void Start () {
		
	}
	
	void Update () {
		
	}
}
