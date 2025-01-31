using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHit : MonoBehaviour
{
    public int health = 10;
    public TextMeshProUGUI healthText;

    public EnemyRegister register;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHit())
        {
            health--;
            healthText.text = health.ToString();
            if (health == 0) Die();
        }
    }

    bool IsHit()
    {
        if (!Input.GetMouseButtonDown(0)) return false;

        Vector2 posDist = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        bool xOverlap = Mathf.Abs(posDist.x) < 1;
        bool yOverlap = Mathf.Abs(posDist.y) < 2;
        return xOverlap && yOverlap;
    }

    void Die()
    {
        register.RemoveEnemy(gameObject);
        Destroy(gameObject);
    }
}
