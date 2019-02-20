using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCajas : MonoBehaviour {
    public GameObject caja;
    private double contador;

	// Use this for initialization
	void Start () {
        contador = 0;
	}
	
	// Update is called once per frame
	void Update () {
        contador += Time.deltaTime;

        if (contador >= 30)
        {
            Instantiate(caja, new Vector3(Random.Range(-450, 800), 70f, Random.Range(-450, 150)), Quaternion.identity);
            contador = 0;
        }
	}
}
