using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
   // public AudioSource effect;
    public void Play()
    {
       // effect.Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
