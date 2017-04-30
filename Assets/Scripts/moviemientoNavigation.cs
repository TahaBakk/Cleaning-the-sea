using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moviemientoNavigation : MonoBehaviour {
			
	public Transform[] target;//Le pasamos los target a los que queremos moverlo
	public float speed;
	public NavMeshAgent agent;
	private int current;

	// Update is called once per frame
	void Update () {

	 	float distancia = Vector3.Distance(target[current].transform.position, transform.position);
		 
		if (distancia>3)
		{
			agent.SetDestination(target[current].transform.position);
			agent.speed = 5;
		}else current = (current+1) % target.Length;
	}

	/*void OnTriggerEnter(Collider other) 
     {
         if (other.tag == "target")
         {
			 //float distancia = Vector3.Distance(other.transform.position, transform.position);
			current = (current+1) % target.Length;
         }
     }*/

}
