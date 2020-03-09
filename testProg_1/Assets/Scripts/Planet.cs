using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    HashSet<Rigidbody> affectedBodies = new HashSet<Rigidbody>();
    Rigidbody compRB;

    void Start()
    {
        compRB = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null )
        {
            affectedBodies.Add(other.attachedRigidbody);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Remove(other.attachedRigidbody);
        }
    }
    void FixedUpdate()
    {
        foreach(Rigidbody body in affectedBodies)
        {
            Vector3 directionToPlanet = (transform.position - body.position).normalized;
            float distance = (transform.position - body.position).magnitude;
            float strength = 10*body.mass*compRB.mass/distance;

            body.AddForce(directionToPlanet* strength);
        }  
    }
}
