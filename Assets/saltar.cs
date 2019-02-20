using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltar : MonoBehaviour {

    public Rigidbody rb;
    public float fuerza = 5f;
    Vector3 salta;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        salta = new Vector3(0.0f, 2.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
       /* if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(salta * fuerza, ForceMode.Impulse);
            //Debug.Log("Salta");
        }*/

    }
}
