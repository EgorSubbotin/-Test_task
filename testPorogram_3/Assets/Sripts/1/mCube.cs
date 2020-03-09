using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mCube : MonoBehaviour
{
    public Vector3 force;
    
    void Start()
    {
         GetComponent<Rigidbody>().AddForce(force);

    }

   
}
