using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LocalPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {

		if (isLocalPlayer) {
			GetComponent<Mvmt> ().enabled = true;

			Camera.main.transform.position = this.transform.position - this.transform.forward * 10 + this.transform.up *10;
			Camera.main.transform.LookAt(this.transform.position);
			Camera.main.transform.parent = this.transform;
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
