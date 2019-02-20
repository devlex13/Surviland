using System.Collections.Generic;
using UnityEngine;
using System;


public class GeneradorZombies : MonoBehaviour {

    public GameObject zombie1;
    public GameObject zombie2;
    public GameObject zombie3;
    public GameObject zombie4;
    public GameObject zombie5;
    public float tiempo = 0f;
    public float segundosRespawn = 5f;

    List<GameObject> listaZombies = new List<GameObject>();
    System.Random rnd;
    void Start () {
        listaZombies.Add(zombie1);
        listaZombies.Add(zombie2);
        listaZombies.Add(zombie3);
        listaZombies.Add(zombie4);
        listaZombies.Add(zombie5);
        
    }

    public void OnTriggerStay(Collider col)
    {
        rnd = new System.Random();
        if (col.tag == "Player")
        {
            tiempo += Time.deltaTime;
            if (tiempo >= segundosRespawn)
            {
                GameObject generador = Instantiate(listaZombies[rnd.Next(0, 6)], this.transform.position, Quaternion.identity);
                tiempo = 0;
            }
        }
    }
}
