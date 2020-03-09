using UnityEngine;

public class CheckGeneration : MonoBehaviour
{
    public static bool point;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            point = true;
        }
    }
}
