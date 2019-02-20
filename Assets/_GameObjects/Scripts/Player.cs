using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Transform bombGenerationPoint;
    public GameObject prefabBomb;
    public int bombsNumber;
    public float force;
	void Update () {
		if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject bomb = Instantiate(prefabBomb, bombGenerationPoint.position, bombGenerationPoint.rotation);
            bomb.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        }
	}
}
