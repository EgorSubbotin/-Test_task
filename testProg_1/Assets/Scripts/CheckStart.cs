using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStart : MonoBehaviour
{
    public static bool start;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Start")
        {
            start = true;
            DiedPlayer.countScore++;
            ControlPlayer.moveSpeed *= 1.3f;
        }
    }
}
