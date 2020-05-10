using UnityEngine;

public class ObjectMove : MonoBehaviour
{

    public float Speed = 200f;
    [SerializeField] public GameObject obstacle;


    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * -Speed, Space.Self);
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("End"))
        {
            Invoke("Destroy", 0.1f);
        }
    }
    void Destroy()
    {
        obstacle.SetActive(false);
    }
}
