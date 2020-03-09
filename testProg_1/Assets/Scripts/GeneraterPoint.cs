
using System;
using System.Collections.Generic;
using UnityEngine;

public class GeneraterPoint : MonoBehaviour
{
    List<GameObject> newPointColec = new List<GameObject>();
    public clon points;
    public static float countPoint;

    
    void FixedUpdate()
    {
        
        if (countPoint < 100)
        {
            countPoint++;
            СreatureCountPoint();
           
        }
        //if (CheckGeneration.goCheckPoint)
        //{
        //    СreatureCountPoint();
        //    //        Debug.Log(newPointColec.Count);
        //    //for (int i = 0; i < newPointColec.Count; i++)
        //    //{
        //    //    if (newPointColec[i].activeInHierarchy)
        //    //    {
        //    //        newPointColec.Remove(newPointColec[i]);
        //    //        СreatureCountPoint();
        //    //        Debug.Log(newPointColec.Count);
        //    //    }
        //    //}

        //}

    }

    void СreatureCountPoint()
    {
        GameObject newPoint1 = points.GetObj();        
        GetVectorPoint(newPoint1);
        newPoint1.transform.rotation = new Quaternion();       
        newPoint1.SetActive(true);        
        newPointColec.Add(newPoint1);       
    }

    void GetVectorPoint(GameObject newPoint1 )
    {
        for (double i = -200; i < 200;)
        {
            i += 0.01;
            float x = UnityEngine.Random.Range(-200, 200);
            float y = UnityEngine.Random.Range(-200, 200);
            float z = (float)Math.Sqrt(Math.Pow(200f, 2) - Math.Pow(x, 2) - Math.Pow(y, 2));
            if (Math.Pow(200f, 2) == Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2))
            {
                Vector3 vec1 = new Vector3(x, y, z);
                Vector3 vec2 = new Vector3(x, y, -z);
                float a = UnityEngine.Random.Range(0, 2);                
                if (a == 0)
                {
                    newPoint1.transform.position = vec1;
                }
                if (a == 1)
                {
                    newPoint1.transform.position = vec2;
                }
                
            }
        }
    }
}
