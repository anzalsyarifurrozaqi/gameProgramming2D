using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTrash : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float respawnTime;
    Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
    }
    private void spawnEnemy() {
        GameObject a = Instantiate(enemy) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }

    // Update is called once per frame
    IEnumerator enemyWave()
    {
        while(true) {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
