using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoController : MonoBehaviour {

	private int vida = 10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	 void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bala")
        {
			vida--;
			if(vida == 0)
			{
			Destroy (GameObject.FindWithTag("naveEnemiga"));
			}
    	}
	}

}
