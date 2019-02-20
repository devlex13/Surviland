using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecogerMunicion : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("Caja"))
        {
            municionDisponible.balas += 150;
            Destroy(col.gameObject);
        }
    }
}
