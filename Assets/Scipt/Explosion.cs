using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour 
{
    public GameObject explosion;
    public Transform player_position;
    //public Animator explosion;
    void Start () 
	{
       
	}
	
	void Update () 
	{
		
	}

    void Create_explosion()
    {
        GameObject explo = Instantiate(explosion, player_position);
    }
}
