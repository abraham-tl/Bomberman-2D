using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_esfera : MonoBehaviour {
    public bool crear;
    int filas;
    int columnas;
    Color[] colore;
    int color;
    GameObject[,] esferas;

    public Comparar comparar;
    public bool compa;
	// Use this for initialization
	void Start () {
        colore = new Color[4];
	}
	
	// Update is called once per frame
	void Update () {
		if (crear )
        {
            Colores();
            Crear_matriz();
            crear = false;
            
        }
        else
        {
            if (compa )
            {
                comparar.Compara(esferas,colore,columnas ,filas);
                compa = false;
            }
        }
	}
    void Crear_matriz()
    {
        columnas = Random.Range(3, 13);
        filas = Random.Range(3, 13);
        esferas= new GameObject [filas,columnas];

        for (int i = 0; i<filas ; i++)
        {
            for (int j = 0;j<columnas;j++)
            {
                color = Random.Range(0,3);
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position  = new Vector3(i * 1.2f, j*1.2f, 0);
                esfera.GetComponent<Renderer>().material.color = colore[color];
                esferas[i,j] = esfera;
            }
           
        }
       
    }
    void Colores()
    {
        colore[0] = Color.blue;
        colore[1] = Color.red;
        colore[2] = Color.yellow;
        colore[3] = Color.green ;
    }

}
