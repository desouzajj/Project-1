using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 100;

    public GameObject fractured;

    public float speed;
    public float rotate;

    void Update()
    {
        // transform.Translate(Vector3.back * speed * Time.deltaTime);
        transform.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(rotate * Time.deltaTime, rotate * Time.deltaTime, rotate * Time.deltaTime);
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
            Destroy(gameObject);
        }
    }
}
