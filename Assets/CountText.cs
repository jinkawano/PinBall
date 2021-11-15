using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountText : MonoBehaviour
{
    int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    public void AddLargeScore()
    {
        score += 20;
    }
    public void AddSmallScore()
    {
        score += 10;
    }
}
