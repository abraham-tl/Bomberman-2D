using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_bom : MonoBehaviour {
    public Transform pos;
    public GameObject Bom;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump") )
        {
            
            Deposit();
            
        }
     
	}
    void Deposit()
    {
       
           
            GameObject bom_ = Instantiate(Bom, pos.transform.position, pos.transform.rotation);
      
        
       
    }
}
