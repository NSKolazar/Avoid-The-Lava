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
            FindObjectOfType<Timer>().timeLeft = 0;
            FindObjectOfType<Timer>().collision = true;
            FindObjectOfType<Timer>().timer.text = "Dead!";
            FindObjectOfType<Manager>().EndGame();
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
