using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;
    public List<Sprite> noteSprites;

    RectTransform rt;

    void Start()
    {
        rt = gameObject.GetComponent<RectTransform>();
    }

    public void KeyPlayed()
    {
        GameObject newNote = Instantiate(notePrefab, rt);
        Sprite randomSprite = noteSprites[Random.Range(0, noteSprites.Count)];
        notePrefab.GetComponent<Image>().sprite = randomSprite;
        Destroy(newNote, 5);
    }
}
