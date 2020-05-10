using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public AudioSource effect;
    public void BeginGame()
    {
        effect.Play();

        SceneManager.LoadScene("Level");
    }
}
