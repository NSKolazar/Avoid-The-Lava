using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    [Header("Info")]
    public string name;
    public AudioClip clip;
    
    [Header("Adjustment")]
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
