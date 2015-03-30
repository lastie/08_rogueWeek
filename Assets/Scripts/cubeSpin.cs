using UnityEngine;
using System.Collections;

public class cubeSpin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, Time.deltaTime * 90f, 0f);
	}
}
