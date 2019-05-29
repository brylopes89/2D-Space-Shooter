using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D shipRb;
    public float moveSpeed;
    public float turnSpeed = 5f;
    public float horizontalInput;

	void Start ()
    {
       shipRb = GetComponent<Rigidbody2D>();

    }
	
	void Update () {

        horizontalInput = Input.GetAxis("Horizontal");
        shipRb.AddTorque(turnSpeed * -horizontalInput);

        if (Input.GetKey(KeyCode.Space))
        {
            shipRb.AddForce(transform.up * moveSpeed);
    
        }

       
    }
}
