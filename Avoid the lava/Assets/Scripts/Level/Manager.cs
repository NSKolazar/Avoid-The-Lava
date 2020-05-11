using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool gameEnded = false;
    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 2f);
        }        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
