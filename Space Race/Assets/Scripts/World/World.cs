using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Intialising Test field
        GameObject testField = GameObject.CreatePrimitive(PrimitiveType.Plane);
        testField.transform.localScale = new Vector3(10f, 1f, 10f);
        Rigidbody testFieldPhysics = testField.AddComponent<Rigidbody>();
        testFieldPhysics.useGravity = false;
        MeshCollider testFieldCollider = testField.AddComponent<MeshCollider>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
