using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public Image tab1Image;
    public Image tab2Image;
    public Image tab3Image;

    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySound()
    {
        audio.PlayOneShot(audio.clip);
    }


    public void ActivateTab1()
    {
        tab1Image.enabled = true;
        tab2Image.enabled = false;
        tab3Image.enabled = false;
        PlaySound();
    }
    public void ActivateTab2()
    {
        tab1Image.enabled = false;
        tab2Image.enabled = true;
        tab3Image.enabled = false;
        PlaySound();
    }
    public void ActivateTab3()
    {
        tab1Image.enabled = false;
        tab2Image.enabled = false;
        tab3Image.enabled = true;
        PlaySound();
    }
}
