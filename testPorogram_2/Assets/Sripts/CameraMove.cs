using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;

    void FixedUpdate()
    {
        Vector3 temp = transform.position;
        temp.z = player.position.z - 35f;
         transform.position=temp;
    }
}
