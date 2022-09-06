using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private float interval;

    // Update is called once per frame
    void Start()
    {
         StartCoroutine(enemySpawn(interval, prefab));
    }

 

    private IEnumerator enemySpawn(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10f, 70f), Random.Range(5f, 40f), -200f), Quaternion.identity);
                Debug.Log("spawn");
        StartCoroutine(enemySpawn(interval, enemy));

    }
}
