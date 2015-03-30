using UnityEngine;
using System.Collections;

public class PathInstantiate : MonoBehaviour {


	// put this on a small cube, it will move around and drop floor modules like breadcrumbs
//UPDATE:
//		If counter is less than 50, then:
//			Generate random number from 0.0f to 1.0f
//			If number is less than 0.25f, then rotate 90 degrees
//			... Else if number is 0.25f-0.5f, then rotate -90 degrees
//				Instantiate a floor tile prefab at current position
//					Move forward (with respect to rotation) by 5 units
//					Increment counter
//					Else
//					Destroy self
					// when you are done, make sure you test this and it's working
	// Use this for initialization

	int tileCounter = 0;
	public Transform floorTileBox;
	public Transform gridGen;
	float gridGenCap;


	void Start () {
		gridGenCap = Random.Range(0.3f, 0.4f);
	}
	
	// Update is called once per frame
	void Update () {
		float r2 = Random.Range (0.0f, 1.0f);
		if (r2 < gridGenCap) {
			Instantiate(gridGen, transform.position, Quaternion.Euler(0f, 0f, 0f));
		}

		if (tileCounter < 100) {
			float randnum = Random.Range(0.0f, 1.0f);
			if (randnum < 0.25f) {
				transform.Rotate(0f, 90f, 0f);
			} else if (randnum < 0.5f) {
				transform.Rotate(0f, -90f, 0f);
			}

			Instantiate(floorTileBox, transform.position, Quaternion.Euler (0f, 0f, 0f));
			transform.position += transform.forward * 5;

			tileCounter += 1;
		} else {
			Destroy(gameObject);
		}

//		if (Input.GetKeyDown (KeyCode.R)) {
//			Application.LoadLevel (Application.loadedLevel);
//		}
	}

	void OnTriggerEnter(Collider stuff) {
		Destroy(stuff);
	}
}
