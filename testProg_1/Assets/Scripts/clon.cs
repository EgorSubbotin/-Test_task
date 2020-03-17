using System.Collections.Generic;
using UnityEngine;

public class clon : MonoBehaviour
{
    List<GameObject> cubes;
    public GameObject primitiv;
    public float num;

    void Start()
    {
        cubes = new List<GameObject>();
        for (int i = 0; i < num; i++)
        {
            GameObject obj = Instantiate(primitiv);
            obj.SetActive(false);
            cubes.Add(obj);
        }
    }
    public GameObject GetObj()
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            if (!cubes[i].activeInHierarchy)
            {
                return cubes[i];
            }
        }
        GameObject obj = Instantiate(primitiv);
        obj.SetActive(false);
        cubes.Add(obj);
        return obj;
    }
}
