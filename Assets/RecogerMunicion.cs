using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecogerMunicion : MonoBehaviour {

    public Slider municion;

	// Use this for initialization
	void Start () {
        int parsed = int.Parse(municionDisponible.balas.ToString());
        municion.maxValue = parsed;
	}
	
	// Update is called once per frame
	void Update () {
        int parsed = int.Parse(municionDisponible.balas.ToString());
        municion.value = parsed;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("Caja"))
        {
            int maximum = municionDisponible.balas += 150;
            municion.maxValue = maximum;
            Destroy(col.gameObject);
        }
    }
}
