using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPlayer : MonoBehaviour
{
    public static float moveSpeed = 40f;
    
    Rigidbody myBody;
    public Transform playerCamera;

    Vector3 right;
    float mouseX;

    public float jumpForce = 1000f;
    
    void Start()
    {

        myBody = GetComponent<Rigidbody>();
    }

    void Update()
    {      
        if (Input.GetMouseButton(0))
        {
            Vector3 down = Vector3.Project(myBody.velocity, transform.up);

            Vector3 forward = transform.forward * moveSpeed;
            if (Input.GetAxis("Mouse X") > 0)
            {
                 right = transform.right * 1f;
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                right = transform.right * (-1f);
            }
            //Vector3 right = transform.right * Input.GetAxis("Mouse X") * 10;
            //myBody.AddForce((forward + right) * Time.fixedDeltaTime * 2000);
            myBody.velocity = down+forward + right;

            if (transform.position.y < 0)
            {
                mouseX = -Input.GetAxis("Mouse X") * 4;
            }

            if (transform.position.y > 0)
            {
                mouseX = Input.GetAxis("Mouse X") * 4;
            }


            transform.Rotate(transform.up, mouseX);
            // playerCamera.Rotate(-Input.GetAxis("Mouse Y") * 2, 0, 0);
            //Debug.Log("Axis"+Input.GetAxis("Mouse X"));
            // Debug.Log("rot" + transform.rotation.y);
        }        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Planet")
        {
            myBody.AddForce(transform.up * jumpForce);            
        }
    }
}
