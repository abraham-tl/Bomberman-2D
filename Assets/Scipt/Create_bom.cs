using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_bom : MonoBehaviour {
    public Transform pos;
    public GameObject Bom;
    
    bool detonacion;
    float t = 3;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump") )
        {
            GameObject bom_ = Instantiate(Bom, pos.transform.position, pos.transform.rotation);
           
        }
      
	}
    
}
