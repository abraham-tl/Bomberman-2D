using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promedio_12 : MonoBehaviour {
//Se declaran las 13 variables para el punto # 5
    float a, b, c, d, e, f, g, h, i, j, k, l, m;
    

	// Use this for initialization
	void Start () {
        //Se asigna el valor de a
        a = 3;
        //Se asigna el valor de b
        b = 6;
        //Se asigna el valor de  C
        c = 9;
        //Se asigna el valor de  D
        d = 11;
        //Se asigna el valor de  E
        e = 13;
        //Se asigna el valor de  F
        f = 15;
        //Se asigna el valor de  G
        g = 17;
        //Se asigna el valor de  H
        h = 1;
        //Se asigna el valor de  I
        i = 3;
        //Se asigna el valor de  J
        j = 6;
        //Se asigna el valor de  K
        k = 9;
        //Se asigna el valor de  L
        l = 1;

        //Se asigna a m las suma de todas la variables
        m = a + b + c + d + e + f + g + h + i + j + k + l;
        //Se divide a m entre 12
        m = m / 12;
        //Se muestra en pantalla el valor de M
        print(m);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
