using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [SerializeField] public AudioSource effect;
    public void Quit()
    {
        effect.Play();
        Application.Quit();
    }
}
