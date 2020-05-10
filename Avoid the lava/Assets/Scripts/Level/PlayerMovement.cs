using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]public float speed = 15f;

    [SerializeField] private Rigidbody rb;
    
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
