using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCube : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Initialising Cube
        GameObject testCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        testCube.transform.localScale = new Vector3(1f, 1f, 1f);
        testCube.transform.position = new Vector3(0f, 3f, 0f);
        // Initialising Physics
        Rigidbody testCubePhysics = testCube.AddComponent<Rigidbody>();
        MeshCollider testMeshCollider = testCube.AddComponent<MeshCollider>();
        testMeshCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check Speed then destroy
    }
}