using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour {

    Transform player;
    NavMeshAgent nav;
    Animator anim;
    BoxCollider collider;
    public int vida = 50;
    public int restarVida = 5;
    float aumento;
    public float velocidadCaida = 1.5f;

    // Use this for initialization
    void Start()
    {
        //player.GetComponent<GameObject>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        this.transform.localScale = new Vector3(0f, 0f, 0f);
        collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x <= 1f )
        {
            aumento += Time.deltaTime/2;
            this.transform.localScale = new Vector3(aumento, aumento, aumento);
        }

        if(vida <= 0)
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * velocidadCaida);
            nav.enabled = false;
            //collider.size = new Vector3(0, 0, 0);
           // collider.enabled = false;
            Destroy(this.gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + 1);

            
            //collider.center = new Vector3(0f, 4.5f, 0f);
        }
        else
        {
            nav.SetDestination(player.position);
        }
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Contains("Bala"))
        {
            vida -= restarVida;
            if (vida <= 0)
            {
                  
                anim.SetBool("Muerto", true);

            }
            Destroy(col.gameObject);

        }
        if (col.gameObject.tag == "MainCamera")
        {
            anim.SetBool("Ataca", true);
        }
        
    }

    public void OnTriggerExit(Collider col)
    {
        anim.SetBool("Ataca", false);
    }

}
