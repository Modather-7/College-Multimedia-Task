using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraView : MonoBehaviour
{
    public GameObject cameraTarget;
    private Transform t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        t = cameraTarget.transform;
        transform.position = new Vector3 (t.position.x, t.position.y, transform.position.z);
    }
}
