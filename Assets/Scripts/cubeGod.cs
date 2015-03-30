using UnityEngine;
using System.Collections;

public class cubeGod : MonoBehaviour {

	public Transform blueprint; // assign in Inspector
	int cubeCountMax = 100;
	float cubeSpawnRadius = 10f;

	// Use this for initialization
	void Start () {

		//Instantiate (blueprint, new Vector3(3.14f, 0.62f, 1f), Quaternion.Euler(0f, 180f, 0f));

		cubeCountMax = Random.Range(100, 1000);
		cubeSpawnRadius = Random.Range (3f, 100f);

		//While loop
//		int cubeCount = 0;
//		while (cubeCount < cubeCountMax) {
//			Instantiate (blueprint, Random.onUnitSphere * cubeSpawnRadius, Random.rotation);
//			cubeCount += 1;
//		}

		//For loop (initialization clause; termination condition; something that executes every time)
		for (int anotherCounter = 0; anotherCounter < 50; anotherCounter += 1 ) {
			Instantiate (blueprint, Random.onUnitSphere * cubeSpawnRadius, Random.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}// reload current scene
	
	}
}
