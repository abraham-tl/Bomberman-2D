using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suma_10 : MonoBehaviour {
    //Se crean 11 variables de tipo entero
    int a, b, c, d, e, f, g, h, i,j,k;
	// Use this for initialization
	void Start () {
        //Se el valor a la variable A
        a = 1;
        //Se el valor a la variable B
        b = 2;
        //Se el valor a la variable C
        c = 3;
        //Se el valor a la variable D
        d = 4;
        //Se el valor a la variable E
        e = 5;
        //Se el valor a la variable F
        f = 6;
        //Se el valor a la variable G
        g = 7;
        //Se el valor a la variable H
        h = 8;
        //Se el valor a la variable I
        i = 9;
        //Se el valor a la variable J
        j = 10;

        //Se le asigna a la variables K la suma de las 10 variables
        k = a + b + c + d + e + f + g + h + i + j;
        //Se muestra en la consola el valor de K
        print(k);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
