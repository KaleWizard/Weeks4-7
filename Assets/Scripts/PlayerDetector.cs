using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public GameObject popup;
    public GameObject player;
    Transform playerTransform;

    public float activationDistance = 1f;
    public float deactivationDistance = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (popup.activeInHierarchy)
        {
            if (Vector2.Distance(playerTransform.position, transform.position) > deactivationDistance)
            {
                popup.SetActive(false);
            }
        } else
        {
            if (Vector2.Distance(playerTransform.position, transform.position) < activationDistance)
            {
                popup.SetActive(true);
            }
        }
    }
}
