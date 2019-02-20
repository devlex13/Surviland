using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorExtra : MonoBehaviour {

    public GameObject extra1;
    public GameObject extra2;
    public GameObject extra3;
    public GameObject extra4;
    public GameObject extra5;
    public float tiempo = 0f;
    public float segundosRespawn = 5f;

    List<GameObject> listaExtra = new List<GameObject>();
    System.Random rnd;
    void Start()
    {
        listaExtra.Add(extra1);
        listaExtra.Add(extra2);
        listaExtra.Add(extra3);
        listaExtra.Add(extra4);
        listaExtra.Add(extra5);

    }

    public void OnTriggerStay(Collider col)
    {
        rnd = new System.Random();
        if (col.tag == "Player" && muroCaido.haCaido)
        {
            tiempo += Time.deltaTime;
            if (tiempo >= segundosRespawn)
            {
                GameObject generador = Instantiate(listaExtra[rnd.Next(0, 6)], this.transform.position, Quaternion.identity);
                tiempo = 0;
            }

        }
    }
}
