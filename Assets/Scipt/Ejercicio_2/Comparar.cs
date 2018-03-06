using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparar : MonoBehaviour {
    int aux;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Compara(GameObject[,] esferas,Color[] colores,int col,int fila)
    {
       
        aux = 0;
        for (int i =0; i <= fila;i++)
        {
            for (int j =0;j<= col;j++)
            {
                if (j> 0)
                {
                    if (esferas[i, j].GetComponent<Renderer>().material.color == esferas[i, j - 1].GetComponent<Renderer>().material.color)
                    {
                        print("HOLAAAAA");
                        print(i);
                        print(j & j-1);
                    }
                }
                
            }
        }
    }
}
