using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetectionSpeechBubble : MonoBehaviour
{
    public GameObject popup;
    Image popupImage;

    public GameObject npc;
    Transform npcTransform;

    public List<Sprite> emotes;


    public float activationDistance = 4f;
    public float deactivationDistance = 6f;

    // Start is called before the first frame update
    void Start()
    {
        npcTransform = npc.transform;
        popupImage = popup.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (popup.activeInHierarchy)
        {
            if (Vector2.Distance(npcTransform.position, transform.position) > deactivationDistance)
            {
                popup.SetActive(false);
            }
        }
        else
        {
            if (Vector2.Distance(npcTransform.position, transform.position) < activationDistance)
            {
                activateEmote();
            }
        }
    }

    void activateEmote()
    {
        popup.SetActive(true);
        Sprite newEmote = emotes[Random.Range(0, emotes.Count)];
        popupImage.sprite = newEmote;
    }
}
