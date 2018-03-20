using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour {

	public GameObject[] SpawnPrefab;
	public float x;
	public float z;
	void Start(){
		Spawnhere ();
	}
	void Spawnhere()
	{
		for (int i = 0; i <5; i++){
			Vector3 position = new Vector3 (Random.Range (-25f, 25f), 0, Random.Range (-22f, 22f));
			Instantiate (SpawnPrefab [0], position, Quaternion.identity);
		}
		for (int i = 5; i <10; i++) {
			Vector3 position = new Vector3 (Random.Range (-25f, 25f), 0, Random.Range (-22f, 22f));
			Instantiate (SpawnPrefab [1], position, Quaternion.identity);
		}

	}
}
