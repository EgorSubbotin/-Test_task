using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMain : MonoBehaviour
{
    public ControlPlayer thePlayer;
    Vector3 lastPlayerPosition;
    float distanceToMove =-13;
    void Start()
    {
        thePlayer = FindObjectOfType<ControlPlayer>();
        lastPlayerPosition = thePlayer.transform.position;
    }
    void Update()
    {
        //distanceToMove = thePlayer.transform.position.z - lastPlayerPosition.z;
        transform.position = new Vector3(thePlayer.transform.position.x , thePlayer.transform.position.y+3, thePlayer.transform.position.z+ distanceToMove);
        transform.rotation = thePlayer.transform.rotation;
        //lastPlayerPosition = thePlayer.transform.position;
        //transform.position = thePlayer.transform.position;
    }
}
