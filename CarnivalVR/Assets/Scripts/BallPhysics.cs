using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    Vector3 controllerCenterOfMass;

    // Start is called before the first frame update
    void Start()
    {
        controllerCenterOfMass = GetComponent<Rigidbody>().centerOfMass;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
