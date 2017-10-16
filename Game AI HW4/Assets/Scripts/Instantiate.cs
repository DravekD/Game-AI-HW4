using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

    Camera cam;
    public Transform main_bird;
    public Transform black_bird;
    public Transform ob1;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		//cam.screenToWorldPoint(new Vector3(x, y, z));
	}
}
