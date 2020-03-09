using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCobe : MonoBehaviour
{
    //public Transform player;    
    //private float speed = 100f;
    //void OnMouseDrag()
    //{
        
    //    if (true)
    //    {
    //        Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
    //        Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);

    //        Vector3 mousePosF= Camera.main.ScreenToWorldPoint(mousePosFar);
    //        Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);

    //        Vector3 mousePos = mousePosF;
    //        float x = mousePos.x/100;
    //        float y = mousePos.y / 100;
    //        float z = mousePos.z / 100;
    //        if (x > Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(y, 2) - Math.Pow(z, 2)))
    //        {
    //            x = (float)Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(y, 2) - Math.Pow(z, 2));
    //        }
    //        if (x < Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(y, 2) - Math.Pow(z, 2)))
    //        {
    //            x = (float)Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(y, 2) - Math.Pow(z, 2));
    //        }
    //        if (y > Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(z, 2)))
    //        {
    //            y = (float)Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(z, 2));
    //        }
    //        if (y < Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(z, 2)))
    //        {
    //            y = (float)Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(z, 2));
    //        }
    //        if (z > Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(y, 2)))
    //        {
    //            z = (float)Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(y, 2));
    //        }
    //        if (z < Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(y, 2)))
    //        {
    //            z = (float)Math.Sqrt(Math.Pow(250f, 2) - Math.Pow(x, 2) - Math.Pow(y, 2));
    //        }
    //        player.position = Vector3.MoveTowards(player.position, new Vector3(x, y, z), speed * Time.deltaTime);

    //        Debug.Log(x);
    //        Debug.Log(y);

    //        Debug.Log(z);


    //        //Vector3 temp = transform.position;
    //        //temp.x = x;
    //        //temp.y = y;
    //        //temp.z = z;
    //        //transform.position = temp;
    //        //Debug.Log(Math.Sqrt(Math.Pow(250f, 2) - Math.Abs(Math.Pow(y, 2) - Math.Pow(z, 2))));
    //    }

    //}
   
}
