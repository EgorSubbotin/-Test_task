 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetConstrain : MonoBehaviour
{
    public Transform thePlanet; 
    
    void FixedUpdate()
    {
        Quaternion rotation = Quaternion.FromToRotation(-transform.up, thePlanet.position - transform.position);
        transform.rotation = rotation * transform.rotation;
    }
}
