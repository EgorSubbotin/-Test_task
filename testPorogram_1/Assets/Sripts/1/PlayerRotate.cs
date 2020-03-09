using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public static Quaternion startPos;   
    float moveX;
    public static Vector3 direction;
    private void Start()
    {
        startPos = transform.rotation;
        direction = transform.right.normalized;
    }

    private void FixedUpdate()
    {

        //if (Input.GetMouseButton(0))
        //{            
            moveX += Input.GetAxis("Mouse X");
            Quaternion rotateY = Quaternion.AngleAxis(moveX, new Vector3(0f, 1f, 0f));
            transform.rotation =  rotateY ;
            direction = -transform.right.normalized;
       // }
    }
}
