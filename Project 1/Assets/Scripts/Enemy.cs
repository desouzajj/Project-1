using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 100;

    public ParticleSystem particle;

    void Awake()
    {
        var outline = gameObject.AddComponent<Outline>();
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineColor = Color.white;
        outline.OutlineWidth = 2f;
       // outline.enabled;

    }
    public void TakeDamage(float damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
           // Debug.Log(hp);
            //Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
            Instantiate(particle, transform.position, Quaternion.identity);
           
            
            Destroy(gameObject, .5f);
            
        }
       
    }


    
}
