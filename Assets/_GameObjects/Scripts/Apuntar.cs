using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntos
{
    public static int p = 0;
}

public class municionDisponible
{
    public static int balas = 50;
}

public class auto
{
    public static bool automatico = false;
}

public class municionBombas
{
    public static int numeroBombas = 10;
}

public class muroCaido
{
    public static bool haCaido = false;
}

public class Apuntar : MonoBehaviour {

    public GameObject Cadera;
    public GameObject Apuntando;
    float tiempo1 = 0;
    float tiempo2 = 0;
    public int vidaJugador = 50;

    // Use this for initialization
    void Start()
    {
        Cadera.SetActive(true);
        Apuntando.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Apuntar"))
        {
            Cadera.SetActive(false);
            Apuntando.SetActive(true);
        }
        else
        {
            Cadera.SetActive(true);
            Apuntando.SetActive(false);
        }

        if (vidaJugador <= 0)
        {
            Cadera.SetActive(false);
            Apuntando.SetActive(false);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Zombie1")
        {
            tiempo1 += Time.deltaTime/2;
            if (tiempo1 >= 2)
            {
                vidaJugador--;
                tiempo1 = 0;
            }
        }

        if (col.gameObject.tag == "Zombie2")
        {
            tiempo1 += Time.deltaTime;
            if (tiempo1 >= 2)
            {
                vidaJugador--;
                tiempo1 = 0;
            }
        }

        if (col.gameObject.tag == "Zombie3")
        {
            tiempo1 += Time.deltaTime / 3;
            if (tiempo1 >= 2)
            {
                vidaJugador--;
                tiempo1 = 0;
            }
        }

        if (col.gameObject.tag == "Zombie4")
        {
            tiempo2 += Time.deltaTime;
            if (tiempo2 >= 2)
            {
                vidaJugador--;
                tiempo2 = 0;
            }
        }

        if (col.gameObject.tag == "Zombie5")
        {
            tiempo2 += Time.deltaTime / 4;
            if (tiempo2 >= 2)
            {
                vidaJugador--;
                tiempo2 = 0;
            }
        }

    }
}
