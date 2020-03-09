using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour
{
    public GameObject goGO;

    Vector3 GO;
    Quaternion q;   
    Vector3 compar;
    float stopFactor = 10;
    float rotaX = 0;

    float moveX;
    void Start()
    {
        GO = goGO.transform.position;
        q = transform.rotation;
    }    
    void FixedUpdate()
    {
        //if (compar.x < PlayerRotate.direction.x || compar.y < PlayerRotate.direction.y
        //    || compar.z < PlayerRotate.direction.z || compar.x > PlayerRotate.direction.x
        //    || compar.y > PlayerRotate.direction.y || compar.z > PlayerRotate.direction.z)
        //{
        //    rotaX = 0;
        //    q = transform.rotation;
        //}


        if (Input.GetMouseButton(0))
        {
            rotaX++;
             moveX += Input.GetAxis("Mouse X");
            Vector3 temp = GO;
            temp.x = PlayerRotate.direction.z;
            GO = -temp;
            Quaternion rotateXYZ = Quaternion.AngleAxis(rotaX/stopFactor,new Vector3(-1f,1f,0f));
            transform.rotation =q*rotateXYZ;

            Debug.Log("X" + GO.x);
            Debug.Log("Y" + GO.y);
            Debug.Log("Z" + GO.x);
            Debug.Log("XR" + rotateXYZ.x);
            Debug.Log("YR" + rotateXYZ.y);
            Debug.Log("ZR" + rotateXYZ.x);
        }
        //compar = PlayerRotate.direction;
    }
}
