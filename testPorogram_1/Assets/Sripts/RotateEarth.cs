using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour
{   
    Quaternion q;   
    Vector3 compar;
    float stopFactor = 10;
    float rotaX = 0;
    void Start()
    {
         
    }    
    void FixedUpdate()
    {
        if (compar.x < PlayerRotate.direction.x || compar.y < PlayerRotate.direction.y
            || compar.z < PlayerRotate.direction.z || compar.x > PlayerRotate.direction.x
            || compar.y > PlayerRotate.direction.y || compar.z > PlayerRotate.direction.z)
        {
            rotaX = 0;
            q = transform.rotation;
        }


        if (Input.GetMouseButton(0))
        {           
               rotaX++;            
            Quaternion rotateXYZ = Quaternion.AngleAxis(rotaX/stopFactor,PlayerRotate.direction);
            transform.rotation =q* rotateXYZ;
        }
        compar = PlayerRotate.direction;
    }
}
