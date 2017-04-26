using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
		}
	}

}
