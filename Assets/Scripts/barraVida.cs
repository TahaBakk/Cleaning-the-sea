using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class barraVida : MonoBehaviour {

	public Scrollbar barraVidabar;
	public float vida = 100;

	public void bajarVida(float value)
	{
		vida -= value;
		barraVidabar.size = vida/100f;

		if(barraVidabar.size == 0)
		{
			Debug.Log("el contador de vida esta en 0");
			SceneManager.LoadScene("GameOver");
		}
		
	}

	void OnTriggerEnter(Collider other) 
     {
         if (other.tag == "balaEnemigo")
         {
			bajarVida(5);
         }
     }

}
