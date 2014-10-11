using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Instantiate(Resources.Load("Cube"),new Vector3(0,0,0),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
