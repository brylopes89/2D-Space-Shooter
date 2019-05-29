using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowScript : MonoBehaviour {

    public GameObject theShip;

    public float followSpeed;

	void Start () {

		
	}

    void FixedUpdate()
    {
        float cameraToShipDistance = Vector2.Distance(transform.position, theShip.transform.position);

        transform.position = Vector2.Lerp(transform.position, theShip.transform.position, followSpeed * cameraToShipDistance * Time.deltaTime);
    }

    void Update () {
		
	}
}
