using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    public GameObject asteroid;
    public float moveSpeed;


	void Start () {

        SpawnNow();
		
	}
	
    void CallSpawn()
    {
        SpawnNow();
    }

    void SpawnNow()
    {
        GameObject go = Instantiate(asteroid, transform.position, transform.rotation);

        go.GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);

        float waitTime = Random.Range(3.0f, 10.0f);

        Invoke("CallSpawn", waitTime);
    
    }

	// Update is called once per frame
	void Update () {
		
	}
}
