using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

	private int count;
//	public Text text;

	void Start (){
		count = 0;
		//updateCounter();
		//winText.text = "";
	}

	void OnTriggerEnter(Collider other) 
     {
         if (other.tag == "pickup")
         {
             Destroy(other.gameObject);
		//count++;

			// updateCounter();
         }
     }
	//Para gestionar los puntos
	/* void updateCounter(){
		text.text = "Puntos: " + count;
		int numPickups = GameObject.FindGameObjectsWithTag("pickup").Length;

		if(numPickups == 1){
			winText.text = "¡Ganaste!";
	 }
	 }*/

}
