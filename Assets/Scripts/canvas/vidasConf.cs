using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class vidasConf : MonoBehaviour {

	public Image imageBar;
	public float barNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		imageBar.fillAmount = barNumber;
	}
}
