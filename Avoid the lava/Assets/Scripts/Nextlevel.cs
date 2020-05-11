using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
    public AudioSource effect;
    public void NextLevel()
    {
        effect.Play();

        SceneManager.LoadScene("Level 2");
    }
}
