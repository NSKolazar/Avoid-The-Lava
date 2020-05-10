using UnityEngine;

public class ObjectMove : MonoBehaviour
{

    public float Speed = 200f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * -Speed, Space.Self);
    }
}
