using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarthX : MonoBehaviour
{
    float num1;
    float num2;
    float stopFactor1 = 10f;
    float stopFactor2=20f;
    float moveX;
    Quaternion rotZ;
    Quaternion pastPos;

    private void Start()
    {
        pastPos = transform.rotation;
        rotZ = Quaternion.AngleAxis(0f, new Vector3(0f, 0f, 1f));
    }
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            num1 += Player.counter;
            Quaternion rotX = Quaternion.AngleAxis((-num1 / stopFactor1), new Vector3(1f, 0f, 0f));

            moveX = Input.GetAxis("Mouse X")*5f;
            if (moveX > 0)
            {
                num2++;
                rotZ = Quaternion.AngleAxis(num2 / stopFactor2, new Vector3(0f, 0f, 1f));
            }
            else if (moveX < 0)
            {
                num2--;
                rotZ = Quaternion.AngleAxis(num2 / stopFactor2, new Vector3(0f, 0f, 1f));
            }

            transform.rotation = pastPos* rotZ * rotX;
            
        }
    }
}
