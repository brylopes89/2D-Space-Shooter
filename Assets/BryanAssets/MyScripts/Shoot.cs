using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject Projectile;
    public float shootSpeed; 

	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            GameObject projectileClone = Instantiate(Projectile, transform.position, transform.rotation);

            projectileClone.GetComponent<Rigidbody2D>().AddForce(transform.up * shootSpeed);

            Destroy(projectileClone.gameObject, 3.0f);

        }
	}
}
