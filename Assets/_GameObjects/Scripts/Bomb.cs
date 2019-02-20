using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    public int timeToExplosion;
    public float radius;
    public float explosionForce;
    public float upwardsModifier;
    public LayerMask layerExplotable;

    public GameObject efecto;
    //public ParticleSystem explosion;
    void Start () {
        Invoke("DoExplosion", timeToExplosion);
    }

	private void DoExplosion()
    {

        Instantiate(efecto, transform.position, transform.rotation);

        Collider[] cols = Physics.OverlapSphere(transform.position, radius, layerExplotable);
        foreach (Collider c in cols)
        {
            
            if (c.GetComponent<Rigidbody>()!=null)
            {
                c.GetComponent<Rigidbody>().isKinematic = false;
                c.GetComponent<Rigidbody>().AddExplosionForce(
                    explosionForce, transform.position, radius, upwardsModifier);
                Destroy(c.gameObject);
            }
        }
    }
}
