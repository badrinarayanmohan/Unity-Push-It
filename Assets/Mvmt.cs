using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvmt: MonoBehaviour {
	
	float speed = 20f;
	float rotSpeed=100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float trans = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float rot = Input.GetAxis ("Horizontal") * rotSpeed * Time.deltaTime;
		transform.Translate (0, 0, trans);
		transform.Rotate (0, rot, 0);
	}
}
