using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    float moveSpeed = 10f;
    
    Rigidbody myBody;
    //public Transform playerCamera;
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            //Vector3 forward = transform.forward * num1/100;
            myBody.velocity = new Vector3(0f, 0f, -moveSpeed);
            Vector3 right = transform.right * Input.GetAxis("Mouse X");
            myBody.AddForce((right) * Time.fixedDeltaTime * 2000);
        }
       



    }
}
