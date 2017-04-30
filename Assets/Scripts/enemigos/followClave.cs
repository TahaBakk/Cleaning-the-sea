using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followClave : MonoBehaviour {

	public Transform[] target;//Le pasamos los target a los que queremos moverlo
	public float speed;

	private int current;
	
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		if (transform.position != target[current].position)
		{
			Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody>().MovePosition(pos);
		}else current = (current+1) % target.Length;
	}

	void OnTriggerEnter(Collider other) 
     {
         if (other.tag == "Player")
         {
			 current = 1;
         }
     }

	 /*void OnTriggerExit(Collider other) 
     {
			 current = 0;
     }*/

}
