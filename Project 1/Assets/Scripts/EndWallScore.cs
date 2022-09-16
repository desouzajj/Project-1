using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWallScore : MonoBehaviour
{
 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Score.scoreValue -= 1;

            Destroy(other.gameObject);
        }


    }
}
