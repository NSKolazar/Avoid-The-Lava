
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        rb.MovePosition(rb.position + Vector3.right * x);
    }
}
