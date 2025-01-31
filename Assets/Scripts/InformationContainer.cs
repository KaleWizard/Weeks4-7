using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationContainer : MonoBehaviour
{
    public List<GameObject> sprites;

    public TextMeshProUGUI infoText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInfoText();
    }

    void UpdateInfoText()
    {
        GameObject go = null;
        for (int i = 0; i < sprites.Count; i++)
        {
            if (sprites[i].GetComponent<Information>().IsMouseOverlapping())
            {
                go = sprites[i];
                break;
            }
        }
        if (go == null)
        {
            infoText.text = "";
        } else
        {
            infoText.text = go.GetComponent<Information>().text;
        }
    }
}
