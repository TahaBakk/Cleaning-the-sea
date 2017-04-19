using System.Collections;
using UnityEngine;

public class movimiento : MonoBehaviour {

	public float speed; //= 1000f;
	public float velRotacion; //= 1000f;
	public float aceleracion;// = 1000f;
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		rigidbody.AddTorque(0f,horizontal*velRotacion*Time.deltaTime,0f);
		rigidbody.AddForce(transform.forward*vertical*aceleracion*Time.deltaTime*-1);
		/*float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 direction = new Vector3(horizontal, 0.0f, vertical);
		GetComponent<Rigidbody>().AddForce(direction * speed);//añadir la  velocidad dependiendo hacia donde le demos*/
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

}
