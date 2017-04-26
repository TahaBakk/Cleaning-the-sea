using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour {

	public GameObject bullet;//el objeto de la bala
	//public Transform disparadores;//desde donde saldra la bala
	public float speed = -70;//velocidad de la bala

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){//si le damos al raton izquierdo dispara
		var bala = (GameObject) Instantiate(bullet,//creamos una variable GameObject y le pasamos la bala
						transform.position, //le pasamos el objeto donde spawneara
						transform.rotation);

		bala.GetComponent<Rigidbody>().velocity = transform.forward * speed;
		
		}
	}
}
