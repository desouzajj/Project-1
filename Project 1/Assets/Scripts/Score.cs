using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private Text score;
    public static int scoreValue = 0;

 

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
      
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;

    }
}
