using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public static Text timer;
    public static float timeLeft = 8;
    public static bool collision = false;

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
        }

                
    }
}
