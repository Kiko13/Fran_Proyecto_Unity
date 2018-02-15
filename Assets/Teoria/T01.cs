using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T01 : MonoBehaviour {

	string nombre = "Fran";
	// Use this for initialization
	void Start () {
		Debug.Log ("Hola " + nombre );

		//Tipos de datos

		// Enteros: int

		int numero = 13;

		// Numeros reales: float -> Numeros con decimales

			float nDecimal = 3.1416f;

		// Cadenas de texto : string

			string mensaje = "Hola bro"; 

		// Valores logicos: bool
		// true == verdadero
		// false == falso

			bool decision = true;

		Debug.Log (numero);
		Debug.Log (nDecimal);
		Debug.Log (mensaje);
		Debug.Log (decision );
	}
}
