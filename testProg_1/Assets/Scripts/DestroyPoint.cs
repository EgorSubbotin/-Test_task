using UnityEngine;

public class DestroyPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Primitive"|| other.gameObject.tag == "Bridge")
        {            
            other.gameObject.SetActive(false);
        }
    }
}
