using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonacion : MonoBehaviour {
    public float t;
    public bool detonacion;
    public GameObject bom;
    public GameObject explosion;
    public GameObject explosio;
	// Use this for initialization
	void Start () {
        t = 3;
        detonacion = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (detonacion )
        {
            Timer();
        }
	}
    void Timer()
    {
        t = t - Time.deltaTime;

        if (t < 0)
        {
            detonacion = false;
            GameObject explo = Instantiate(explosion, bom.transform.position ,bom.transform .rotation );
            GameObject explo2 = Instantiate(explosio, bom.transform.position, bom.transform.rotation);
            Destroy(bom);
           
        }
    }
}
