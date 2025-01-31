using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRegister : MonoBehaviour
{
    public GameObject enemyPrefab;

    public List<GameObject> enemies;

    public GameObject victoryMessage;

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 5; i++)
        {
            Vector2 randomScreenPosition = new Vector2(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height));
            Vector2 randomPosition = Camera.main.ScreenToWorldPoint(randomScreenPosition);
            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            newEnemy.GetComponent<EnemyHit>().register = this;
            enemies.Add(newEnemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveEnemy(GameObject enemy)
    {
        enemies.Remove(enemy);
        CheckForWin();
    }

    void CheckForWin()
    {
        if (enemies.Count == 0)
        {
            victoryMessage.SetActive(true);
        }
    }
}
