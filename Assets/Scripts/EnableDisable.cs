using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    SpriteRenderer sr;
    EnableDisable ed;
    public GameObject go;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        ed = gameObject.GetComponent<EnableDisable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = !sr.enabled;
            if (sr.enabled) 
                audioSource.PlayOneShot(audioSource.clip);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            go.SetActive(!go.activeInHierarchy);
        }

        if (Input.GetMouseButtonDown(1))
        {
            ed.enabled = !ed.enabled;
        }
    }
}
