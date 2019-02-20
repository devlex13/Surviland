using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Disparar : MonoBehaviour {

    public GameObject prefabProyectil;
    public Transform salidaBala;
    public ParticleSystem explosion;
    /*public Transform salidaCasquillo;
    public float fuerzaCasquillo = 0.1f;
    public GameObject prefabCasquillo;*/
    public float fuerzaDisparo = 0.1f;
    public AudioClip disparo;//El fichero de sonido
    private AudioSource audioSource;
    Animator anim;
    private double contador;

    public Transform bombGenerationPoint;
    public GameObject prefabBomb;
    public float force;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        explosion.Stop();
        contador = 0;
    }

    void Update()
    {
        if (municionBombas.numeroBombas > 0)
        {
            if (Input.GetButtonDown("Granada"))
            {
                GameObject bomb = Instantiate(prefabBomb, bombGenerationPoint.position, bombGenerationPoint.rotation);
                bomb.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
                municionBombas.numeroBombas--;
            }
        }
        if (municionDisponible.balas > 0)
        {
            Debug.Log(municionDisponible.balas);
            if (Input.GetButtonDown("Modo") && auto.automatico == false)
            {
                auto.automatico = true;
            }
            else if (Input.GetButtonDown("Modo") && auto.automatico == true)
            {
                auto.automatico = false;
            }
            if (auto.automatico == false)
            {
                if (Input.GetButtonDown("Disparar"))
                {
                    municionDisponible.balas -= 1;
                    GameObject proyectil =
                        Instantiate(
                            prefabProyectil,
                            salidaBala.position,
                            salidaBala.rotation);
                    proyectil.GetComponent<Rigidbody>().AddForce(
                        transform.forward * fuerzaDisparo,
                        ForceMode.Impulse);
                    explosion.Emit(10);
                    explosion.Play();
                    /*GameObject casquillo =
                        Instantiate(
                            prefabCasquillo,
                            salidaCasquillo.position,
                            Quaternion.identity);
                    casquillo.GetComponent<Rigidbody>().AddForce(
                        transform.forward * fuerzaCasquillo,
                        ForceMode.Impulse);*/
                    //anim.SetBool("Disparo", true);
                    //Debug.Log(anim.GetBool("Disparo"));

                    anim.Play("RetrocesoCadera");
                    anim.Play("RetrocesoApuntandoChetada");
                    audioSource.PlayOneShot(disparo);
                    Destroy(proyectil, 4);
                }
                else
                {
                    //explosion.Emit(0);
                    explosion.Stop();
                }

            }
            else
            {
                if (Input.GetButton("Disparar"))
                {
                    contador += Time.deltaTime;

                    if (contador >= 0.2)
                    {
                        municionDisponible.balas -= 1;
                        GameObject proyectil =
                            Instantiate(
                                prefabProyectil,
                                salidaBala.position,
                                salidaBala.rotation);
                        proyectil.GetComponent<Rigidbody>().AddForce(
                            transform.forward * fuerzaDisparo,
                            ForceMode.Impulse);
                        explosion.Emit(10);
                        explosion.Play();
                        /*GameObject casquillo =
                            Instantiate(
                                prefabCasquillo,
                                salidaCasquillo.position,
                                Quaternion.identity);
                        casquillo.GetComponent<Rigidbody>().AddForce(
                            transform.forward * fuerzaCasquillo,
                            ForceMode.Impulse);*/
                        //anim.SetBool("Disparo", true);
                        //Debug.Log(anim.GetBool("Disparo"));

                        anim.Play("RetrocesoCadera");
                        anim.Play("RetrocesoApuntandoChetada");
                        audioSource.PlayOneShot(disparo);
                        Destroy(proyectil, 4);

                        contador = 0;
                    }
                }
                else
                {
                    //explosion.Emit(0);
                    explosion.Stop();
                }
            }
        }
        else
        {
            explosion.Stop();
        }

    }
}
