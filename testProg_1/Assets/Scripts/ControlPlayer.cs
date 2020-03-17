using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public static float moveSpeed = 25f;
    Rigidbody myBody;
    float mouseX;
    public float jumpForce = 1000f;

    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!DiedPlayer.DeathPlayer)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 down = Vector3.Project(myBody.velocity, transform.up);

                Vector3 forward = transform.forward * moveSpeed;

                myBody.velocity = down + forward;

                mouseX = +Input.GetAxis("Mouse X") * 2;

                transform.Rotate(new Vector3(0, 1, 0), mouseX);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Planet")
        {
            myBody.AddForce(transform.up * jumpForce);
        }
    }
}
