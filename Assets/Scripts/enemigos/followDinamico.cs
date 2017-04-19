using System.Collections;
using UnityEngine;

public class followDinamico : MonoBehaviour {

	public Transform[] target;//Le pasamos los target a los que queremos moverlo
	public float speed;

	private int current;

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
         if (other.tag == "target")
         {
			 current = (current+1) % target.Length;
         }
     }
}
