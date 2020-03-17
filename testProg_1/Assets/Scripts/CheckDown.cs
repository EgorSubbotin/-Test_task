using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDown : MonoBehaviour
{
    public static bool start;
    public static bool down;
    public static float countDown = 1f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Down")
        {
            if (countDown == 1)
            {
                down = true;
                countDown++;
            }
            else if (countDown == 2)
            {
                down = false;
                countDown = 1f;
            }
        }
        if (other.gameObject.tag == "Start")
        {
            start = true;
            DiedPlayer.countScore++;
            ControlPlayer.moveSpeed *= 1.3f;            
        }
    }
}
