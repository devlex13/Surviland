using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDisparo : MonoBehaviour {

    public float delay = 1.0f;

    void Update()
    {
        
            delay -= Time.deltaTime;
            if (delay < 0f)
                GameObject.Destroy(this.gameObject);
        
       
    }
}
