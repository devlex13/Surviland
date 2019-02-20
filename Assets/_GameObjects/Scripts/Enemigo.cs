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
            nav.enabled = false;
            collider.size = new Vector3(3.0f, 1.0f, 2.0f);
            collider.center = new Vector3(0f, 4.5f, 0f);
        }
        nav.SetDestination(player.position);
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Contains("Bala"))
        {
            vida -= restarVida;
            Debug.Log(vida);
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
