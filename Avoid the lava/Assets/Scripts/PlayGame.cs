using UnityEngine;
using UnityEngine.SceneManagement;

public class PlazGame : MonoBehaviour
{
    public AudioSource effect;
    public void PlayGame()
    {
        effect.Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
