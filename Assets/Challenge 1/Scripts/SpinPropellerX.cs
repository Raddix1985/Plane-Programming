using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // private variable
    private float propellerSpeed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spin propeller on z axis
        transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}
