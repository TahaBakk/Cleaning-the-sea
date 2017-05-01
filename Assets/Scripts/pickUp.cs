using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickUp : MonoBehaviour {
	
	public Text text;
	private float count = 60f;

	// Use this for initialization
	void Start () {
		//count = 0;
		//updateCounter();
	}
	
	// Update is called once per frame
	void Update () {

		count -= Time.deltaTime;
		text.text = "00:"+ count.ToString("f0");
		if(count == 0){
			SceneManager.LoadScene("Menu");
		}
		
	}

	void OnTriggerEnter(Collider other) 
     {
         if (other.tag == "pickup")
         {
            SceneManager.LoadScene("Menu");

         }
     }
		//text.text = "Puntos: " + count;
		//int numPickups = GameObject.FindGameObjectsWithTag("pickup").Length;

		/*if(numPickups == 1){//Si los coje todos que hacer
			winText.text = "¡Ganaste!";
		}*/


}
