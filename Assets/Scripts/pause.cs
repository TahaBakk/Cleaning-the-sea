using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pause : MonoBehaviour {

	private bool paused = false;
	public Text text;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p") && paused == false)
		{
			paused = true;
			Time.timeScale = 0;
			text.text = "Game paused";
		}else if(Input.GetKeyDown("p") && paused == true)
		{
			paused = false;
			Time.timeScale = 1;
			text.text = "";

		}
	}
}
