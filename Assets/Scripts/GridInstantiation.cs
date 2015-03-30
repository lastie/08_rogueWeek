using UnityEngine;
using System.Collections;

public class GridInstantiation : MonoBehaviour {

	// put this on a small cube, it will instantiate a grid of 5x5 floors with random walls
//START:
//		for ( integer X starts at zero; as long as X is less than 5; increment X):
//			for ( integer Z starts at zero; as long as Z is less than 5; increment Z):
//				Generate a temporary Vector3 "pos" of "(X * 5, 0, Z * 5) + current position"
//					70% chance to instantiate a floor tile prefab at "pos"
//					25% chance to instantiate a wall tile prefab at "pos"
//					5% chance to instantiate nothing
//					Destroy self
					// when you are done, make sure you test this and it's working

	// Use this for initialization

	public Transform floorPrefab;
	public Transform wallPrefab;
	public Transform pathGen;
	float pathGenCap;


	void Start () {
		pathGenCap = Random.Range(0.7f, 0.9f);

		float r2 = Random.Range(0.0f, 1.0f);
		if (r2 < pathGenCap) {
			Instantiate(pathGen, transform.position, Quaternion.Euler(0f, 0f, 0f));
		}

		for (int x = 0; x < 5; x++) {
			for (int z = 0; z < 5; z++) {
				Vector3 pos = new Vector3(x * 5, 0, z * 5) + transform.position;
				float random = Random.Range(0.0f, 1.0f);
				if (random < 0.7f) {
					Instantiate(floorPrefab, pos, Quaternion.Euler(0f, 0f, 0f));
				} else if (random < 0.95f) {
					Instantiate(wallPrefab, pos, Quaternion.Euler(0f, 0f, 0f));
				}
			}
		}

		Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
