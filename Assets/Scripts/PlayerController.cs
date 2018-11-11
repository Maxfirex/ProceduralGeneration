using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        var xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
        var zAxis = Input.GetAxis("Vertical") * Time.deltaTime * 3f;

        transform.Rotate(0, xAxis, 0);
        transform.Translate(0, 0, zAxis);
	}
}
