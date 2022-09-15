using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BulletCountUI : MonoBehaviour
{
    private Text bulletCount;
    public static int ammoClip = 30;
    // Start is called before the first frame update
    void Start()
    {
        bulletCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletCount.text = "Ammunition: " + ammoClip;
    }
}
