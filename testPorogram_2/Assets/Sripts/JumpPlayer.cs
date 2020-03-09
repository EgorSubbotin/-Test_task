using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    Rigidbody player;
    public float jumpForce = 5f;
    public static bool  alivePlayer;    
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Earth"|| collision.gameObject.tag=="Bridge")
        {
            player.velocity = new Vector3(0f, jumpForce, 0f);
        }
    }    
}
