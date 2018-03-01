using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_player : MonoBehaviour {
    public GameObject player;
    public float velocidad;
    float trasladar;
    public Animator animator;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetAxis("Horizontal") != 0)
        {
            float trasladar = Input.GetAxis("Horizontal") * velocidad;
            trasladar *= Time.deltaTime;
          
            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("run_der", true);
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("reun_izq", true);
            }
            transform.Translate(Vector2.right * trasladar);
        }
        else
        {
            animator.SetBool("reun_izq", false);
            animator.SetBool("run_der", false);
        }
       
        
        if (Input.GetAxis("Vertical") != 0)
        {
            trasladar = Input.GetAxis("Vertical") * velocidad;
            trasladar *= Time.deltaTime;
            
            if (Input.GetAxis("Vertical") > 0)
            {
                animator.SetBool("run_up", true);
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                animator.SetBool("run_down", true);
            }
            transform.Translate(Vector2.up * trasladar);
        }
        else
        {
            animator.SetBool("run_up", false);
            animator.SetBool("run_down", false);
        }
    }
}
