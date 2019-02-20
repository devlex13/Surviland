using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CambioDeArma : MonoBehaviour {

    public GameObject negroRojoCadera;
    public GameObject negroAzulCadera;
    public GameObject grisDoradoCadera;

    public GameObject negroRojoApuntando;
    public GameObject negroAzulApuntando;
    public GameObject grisDoradoApuntando;

    public GameObject armas;
    Animator anim;
    int numeroArma = 0;

    // Use this for initialization
    void Start () {

        anim = armas.GetComponent<Animator>();

        negroRojoCadera.SetActive(true);
        negroAzulCadera.SetActive(false);
        grisDoradoCadera.SetActive(false);

        negroRojoApuntando.SetActive(true);
        negroAzulApuntando.SetActive(false);
        grisDoradoApuntando.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("CambiarArma"))
        {
            numeroArma++;
            if (numeroArma == 1)
            {
                anim.Play("AnimacionCambioArma");

                negroRojoCadera.SetActive(true);
                negroAzulCadera.SetActive(false);
                grisDoradoCadera.SetActive(false);

                negroRojoApuntando.SetActive(true);
                negroAzulApuntando.SetActive(false);
                grisDoradoApuntando.SetActive(false);
            }else if (numeroArma == 2)
            {
                anim.Play("AnimacionCambioArma");

                negroRojoCadera.SetActive(false);
                negroAzulCadera.SetActive(true);
                grisDoradoCadera.SetActive(false);

                negroRojoApuntando.SetActive(false);
                negroAzulApuntando.SetActive(true);
                grisDoradoApuntando.SetActive(false);
            }else if(numeroArma == 3) {
                anim.Play("AnimacionCambioArma");

                negroRojoCadera.SetActive(false);
                negroAzulCadera.SetActive(false);
                grisDoradoCadera.SetActive(true);

                negroRojoApuntando.SetActive(false);
                negroAzulApuntando.SetActive(false);
                grisDoradoApuntando.SetActive(true);
                numeroArma = 0;
            }
            
        }

	}
}
