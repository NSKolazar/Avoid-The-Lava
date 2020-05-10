using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] public PlayerMovement movement;
    [SerializeField] public GameObject player;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            Timer.timeLeft = 0;
            Timer.collision = true;
            Timer.timer.text = "Dead!";
        }
        if (collisionInfo.collider.CompareTag("End"))
        {
            Invoke("Destroy", 0.1f);
        }
    }
    void Destroy()
    {
        player.SetActive(false);
    }
}
