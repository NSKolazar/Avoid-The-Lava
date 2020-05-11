using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Timer2 : MonoBehaviour
{
    public Text timer;
    public float timeLeft = 10;
    public bool collision = false;
    [SerializeField] public AudioSource success;

    private void Start()
    {
        StartCoroutine(Countdown());
    }
    public IEnumerator Countdown()
    {

        timer = GetComponent<Text>();
        while (timeLeft > 0)
        {
            timer.text = "Time: " + timeLeft-- + "s";

            yield return new WaitForSecondsRealtime(1);
        }
        if (timeLeft == 0 && collision == false)
        {
            timer.text = "Phew! You survived.";
            success.Play();
            yield return new WaitForSecondsRealtime(1);
            FindObjectOfType<Manager>().CompleteLevel();
        }


    }
}