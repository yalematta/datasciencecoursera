using UnityEngine;
using System.Collections;

public class MyDebugDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Starting...");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Updating!");
        transform.Translate(Vector3.forward * Time.deltaTime);
	}
}
