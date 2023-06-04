using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource, bgSource;

    private void Awake() 
    {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    private void Start() 
    {
        PlayMusic("Theme");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x. name == name);
        if (s == null) {
            Debug.Log("Sound Not Found");
        }
        else {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PauseMusic()
    {
        musicSource.Pause();
    }

    public void ControlMusic(float volume)
    {
        musicSource.volume = volume;
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        if (s == null) {
            Debug.Log("Sound Not Found");
        }
        else {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void PlayBG(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        if (s == null) {
            Debug.Log("Sound Not Found");
        }
        else {
            bgSource.clip = s.clip;
            bgSource.Play();
        }
    }

    public void PauseBG()
    {
        bgSource.Pause();
    }

    public void ControlBG(float volume)
    {
        bgSource.volume = volume;
    }

}
