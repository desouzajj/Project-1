using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Start()
    {
       
    }

    void Update()
    {
        StartCoroutine(enemySpawn());
    }
    void Spawn()
    {
        
    }

    IEnumerator enemySpawn()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(prefab, new Vector3(Random.Range(10f, 30f), Random.Range(15f, 30f), -200f), Quaternion.identity);
                Debug.Log("spawn");
        //Spawn();
    }
}
