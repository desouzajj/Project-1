using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public GameObject player;
    public float distance;
    private float proximity = 3f;
    public GameObject ammoBox;
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, ammoBox.transform.position);
        if (distance <= proximity && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("add ammo here");
            BulletCountUI.ammoClip += 20;
           // Destroy(gameObject);
        }
    }
}
