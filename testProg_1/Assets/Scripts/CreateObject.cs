using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public clon[] prim;
    int select;
    Rigidbody primitRB;

    Vector3 lastPosition;
    private void Start()
    {
        StartCoroutine(SetPrimit());
        lastPosition = transform.position;
    }

    IEnumerator SetPrimit()
    {
        yield return new WaitForSeconds(2f);
        if (Math.Abs(transform.position.z - lastPosition.z) > 3.3)
        {
            СreatureCountPoint();
        }
        StartCoroutine(SetPrimit());
    }

    void СreatureCountPoint()
    {
        select = UnityEngine.Random.Range(0, prim.Length);
        GameObject newPoint1 = prim[select].GetObj();
        newPoint1.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        newPoint1.transform.rotation = Quaternion.Euler(UnityEngine.Random.Range(-180, 180), UnityEngine.Random.Range(-180, 180), UnityEngine.Random.Range(-180, 180));
        primitRB = newPoint1.GetComponent<Rigidbody>();
        lastPosition = transform.position;
        newPoint1.SetActive(true);
        Statistics.countCreateOblect++;
        Statistics.numberObjects++;
    }
}
