using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public AudioSource effect;
    public void BeginGame()
    {
        effect.Play();
        Invoke("Begin",1f);
    }

    void Begin()
    {
        SceneManager.LoadScene("Level");
    }
}
