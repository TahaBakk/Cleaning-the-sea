using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acciones : MonoBehaviour {

 	public Transform target;//nuestra nave
    public float speed = 3;
    public float giroSpeed = 3;
    public float distance = 25f;//distancia en que el enemigo lo puede ver
    public bool Enabled = false;//Para saber si esta dentro de nuestra area
    public bool Detect = false;//si el jugador esta en el area del enemigo
    private Transform myTransform;//lo utilizaremos para moverlo sin tener que usar las fisicas (V3)


    void Awake()
    {
        myTransform = this.GetComponent<Transform>();
    }


    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        if (Enabled)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), giroSpeed * Time.deltaTime);//que se ponga a mirar hacia la direcion del jugador
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
            else//en caso de que el jugador este dentro del area pero que no me detecte
            {
                Detect = false;
            }
        }
        if (Enabled && Detect)//hacemos que lo persiga si esta en el rango de vision y esta dentro del area
        {
            myTransform.position += myTransform.forward * speed * Time.deltaTime;
        }
    }



    //No metemos el codigo dentro del trigger ya que si estoy en el rango se estaria ejecutando hasta que salga y el juego iria lento
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
