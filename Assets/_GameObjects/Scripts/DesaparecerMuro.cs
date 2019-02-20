using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerMuro : MonoBehaviour {

    public GameObject contendor;
    public GameObject muro;
    public int puntosNecesarios = 50;
    Rigidbody rb;


	// Use this for initialization
	void Start () {
        muro.GetComponent<GameObject>();
        contendor.GetComponent<GameObject>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (puntos.p == puntosNecesarios)
        {
            rb.useGravity = true;
        }
        if (muro.transform.position.y < -670)
        {
            Destroy(muro);
            Destroy(contendor);
            muroCaido.haCaido = true;
        }
	}
}
