using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] points;   
    public Transform genertPoint;
    public Transform theEarth;
    public clon[] prim;
    int select;
    int indexNewPim=-1;
    GameObject[] newPrim;

    void Start()
    {
        newPrim = new GameObject[points.Length];        
    }

    void Update()
    {
        if (CheckGeneration.point)
        {
            indexNewPim++;
            if (indexNewPim == 7)
            {
                indexNewPim = 0;
               // RotateEarthX.stopFactor1 *= 1.3f;
            }
            Debug.Log(indexNewPim);
            CheckGeneration.point=false;
            select = Random.Range(0, prim.Length);
            newPrim[indexNewPim] = prim[select].GetObj();
            newPrim[indexNewPim].SetActive(true);
        }
        for (int i = 0; i <= indexNewPim; i++)
        {
            if (newPrim[i] != null)
            {
                newPrim[i].transform.position = points[i].transform.position;
                newPrim[i].transform.rotation = points[i].transform.rotation;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Primitive")
        {
            collision.gameObject.SetActive(false);
        }        
    }
}
