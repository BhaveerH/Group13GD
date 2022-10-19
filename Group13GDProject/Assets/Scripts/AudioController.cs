using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Sound 
{
    public string name;
    public AudioClip clip;

    private AudioSource source;

    public void SetSource(AudioSource _source)
    {
        source = _source;
        source.clip = clip;
    }

    public void Play()
    {
        source.Play();
    }

public class AudioController : MonoBehaviour
    {
        [SerializeField] Sound[] sounds;
    }
}
