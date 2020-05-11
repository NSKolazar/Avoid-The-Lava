using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [SerializeField] AudioSource effect;
    public void Quit()
    {
        effect.Play();
        Debug.Log("Quit");
        Application.Quit();
    }
}
