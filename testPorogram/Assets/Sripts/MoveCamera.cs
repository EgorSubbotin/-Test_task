using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //public Transform player;
    private void Start()
    {
       


    }
    void Update()
    {
        Vector3 temp = transform.position;
        temp.y = 505.5f;
        transform.position = temp;
        //transform.rotation = Quaternion.Euler(transform.rotation.x, player.rotation.y, transform.rotation.z);
    }
}
