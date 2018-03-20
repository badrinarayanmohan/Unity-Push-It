using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Newtimer : MonoBehaviour {

	public float myTimer=45;
	public Text timerText;

	void Start () {
		timerText = GetComponent<Text> ();
	}
	

	void Update () {
		myTimer -= Time.deltaTime;
		if (myTimer <= 0) {
			myTimer = 0;
		}
		timerText.text = myTimer.ToString ("f0");
		//print (myTimer);

	}
}
