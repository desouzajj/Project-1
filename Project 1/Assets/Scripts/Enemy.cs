using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 100;




    public void TakeDamage(float damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            Debug.Log(hp);
            //Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
            Destroy(gameObject);
        }
    }
}
