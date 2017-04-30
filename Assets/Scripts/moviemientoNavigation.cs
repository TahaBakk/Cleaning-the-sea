using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moviemientoNavigation : MonoBehaviour {
			
	public Transform[] target;//Le pasamos los target a los que queremos moverlo
 	public Transform targetNave;//nuestra nave
	public float speed;
	public float giroSpeed = 3;
	public NavMeshAgent agent;
	private int current;
	public float distance = 25f;//distancia en que el enemigo lo puede ver
	public bool Enabled = false;//Para saber si esta dentro de nuestra area
    public bool Detect = false;//si el jugador esta en el area del disparo
	public GameObject bullet;//el objeto de la bala
	public float speedDisparo = -70;//velocidad de la bala
	private Transform myTransform;//lo utilizaremos para moverlo sin tener que usar las fisicas (V3)

	void Awake()
    {
        myTransform = this.GetComponent<Transform>();
    }
	// Update is called once per frame
	void Update () {


		if (Enabled)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(targetNave.position - myTransform.position), giroSpeed * Time.deltaTime);//que se ponga a mirar hacia la direcion del jugador
            RaycastHit info;//es un rayo imaginario que usaremos para saber si la nave esta en el area o no el rayCastHit nos devuelve true o false
            Debug.DrawRay(transform.position, transform.forward * distance, Color.red, 0.1f);//en la scena nos muestra el rango con una linia corja
            if (Physics.Raycast(transform.position, transform.forward, out info, distance))
            {
                if (info.collider.tag == "Player")
                {
                    Detect = true;
                }
                else
                {
                    Detect = false;
                }
            }
            
        }else
        {
          patrullar();
        }
        if (Enabled && Detect)//hacemos que le dispare si esta en el rango de vision y esta dentro del area
        {
			perseguirDisparar();
		}
		
	}


	void patrullar()
	{
		float distancia = Vector3.Distance(target[current].transform.position, transform.position);

			if (distancia>3)
			{
				agent.SetDestination(target[current].transform.position);
				agent.speed = 5;
			}else current = (current+1) % target.Length;
	}

	void detectar()
	{
		
	}
	void perseguirDisparar()
	{
		agent.SetDestination(targetNave.transform.position);
		agent.speed = 5;
        var bala = (GameObject) Instantiate(bullet,//creamos una variable GameObject y le pasamos la bala
				transform.position, //le pasamos el objeto donde spawneara
				transform.rotation);

		bala.GetComponent<Rigidbody>().velocity = transform.forward * speedDisparo;
//		WaitForSeconds(0.1f);//esperar medio segundopara que las balas no salgan muchas al mismo tiempo
	}


	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Enabled = false;
        }
	}

}
