using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    }
}
