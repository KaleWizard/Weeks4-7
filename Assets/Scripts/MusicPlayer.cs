using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audio;

    public TimeBar musicSlider;

    public TMP_Dropdown dropdown;

    public List<AudioClip> songs;

    int currentSong = -1;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        currentSong = dropdown.value;
        Debug.Log(dropdown == null);
        Debug.Log(currentSong.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSong != dropdown.value)
        {
            Debug.Log(dropdown == null);
            Debug.Log(currentSong.ToString());
            currentSong = dropdown.value;
            audio.clip = songs[dropdown.value];
            audio.time = 0f;
        }
    }


    public void PauseMusic()
    {
        audio.Pause();
    }

    public void PlayMusic()
    {
        if (!audio.isPlaying)
        {
            audio.Play();
        }
    }
}
