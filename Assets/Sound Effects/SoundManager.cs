using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{
    public static SoundManager Instance { get; private set; } 
    private AudioSource _source;

    public void Awake() 
    {
        Instance = this;
        _source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
        _source.PlayOneShot(clip);
    }    
    
}
    