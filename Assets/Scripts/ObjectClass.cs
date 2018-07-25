using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClass : MonoBehaviour {

    [SerializeField] float objectSpeed = 1;
    private float resetPosition = 42;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * objectSpeed * Time.deltaTime);

        if (transform.localPosition.x <= resetPosition) {
            Vector3 newPos = new Vector3(123, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
	}
}
