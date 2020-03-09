using System.Collections.Generic;
using UnityEngine;

public class CheckGeneration : MonoBehaviour
{
    public clon[] prim;
    int select;
    //public static bool goCheckPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            if (other.gameObject.activeInHierarchy)
            {
                
                select = Random.Range(0, prim.Length);

                GameObject newPrim = prim[select].GetObj();
                newPrim.transform.position = other.gameObject.transform.position;
                newPrim.transform.rotation = other.gameObject.transform.rotation;               
                newPrim.SetActive(true);

                //Destroy(other.gameObject);
                //other.gameObject.SetActive(false);
                //goCheckPoint = true;
            }
            
            //Destroy(other.gameObject);
            
        }
    }
}
