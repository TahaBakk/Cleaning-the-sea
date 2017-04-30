using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pickUp : MonoBehaviour {
	
	public Text text;
	private int count;

	// Use this for initialization
	void Start () {
		count = 0;
		updateCounter();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) 
     {
         if (other.tag == "pickup")
         {
             //Destroy(other.gameObject);
			 count++;

			 updateCounter();
         }
     }

	 void updateCounter(){
		text.text = "Puntos: " + count;
		int numPickups = GameObject.FindGameObjectsWithTag("pickup").Length;

		/*if(numPickups == 1){//Si los coje todos que hacer
			winText.text = "¡Ganaste!";
		}*/

	 }


}
