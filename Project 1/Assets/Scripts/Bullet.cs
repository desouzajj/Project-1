using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 50f;

    public ParticleSystem particle;

    public GameObject bulleteffect;

    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();


  

  

    public float bulletTime = 2f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && BulletCountUI.ammoClip > 0 && Score.scoreValue >=0)
        {
            particle.Play();
            //StartCoroutine(BulletCount());
             BulletCountUI.ammoClip -= 1;
   
        }
        
    }
    private void OnParticleCollision(GameObject other)
    {
        int events = particle.GetCollisionEvents(other, colEvents);


        for(int i=0; i < events; i++)
        {
            Instantiate(bulleteffect, colEvents[i].intersection, Quaternion.LookRotation(colEvents[i].normal));
        }

        if(other.TryGetComponent(out Enemy en))
        {
            en.TakeDamage(damage);
        }
    }

   // IEnumerator BulletCount()
   // {
   //     yield return new WaitForSeconds(bulletTime);
   //     particle.Play();
   //    
   //     Debug.Log(BulletCountUI.ammoClip);
   //    // Debug.Log("delayed here");
   // }

  
}

