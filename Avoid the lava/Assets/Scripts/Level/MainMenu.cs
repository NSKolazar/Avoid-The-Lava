using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource effect;
    public void MenuScreen()
    {
        effect.Play();

        SceneManager.LoadScene("Main menu");
    }
}
