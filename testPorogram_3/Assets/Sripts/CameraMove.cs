using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;

    Quaternion startPosition;
    float moveX;
    float moveY;
    void FixedUpdate()
    {
        //Vector3 temp = transform.position;
        //temp.z = player.position.z - 35f;
        // transform.position=temp;

        moveX += Input.GetAxis("Mouse X") * 5f;
        moveY += Input.GetAxis("Mouse Y");

        Quaternion angleY = Quaternion.AngleAxis(moveX, new Vector3(0f, 1f, 0f));
        Quaternion angleX = Quaternion.AngleAxis(-moveY, new Vector3(1f, 0f, 0f));
        moveY = Mathf.Clamp(moveY, -15, 15);
        transform.rotation = startPosition * angleY * angleX;
    }
}
