using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallController : MonoBehaviour
{
    private GameObject gameoverText;
    GameObject scoreObject;
    private float visiblePosZ = -6.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");        
        scoreObject = GameObject.Find("GameObject");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LargeCloudTag" || collision.gameObject.tag == "LargeStarTag")
        {
            scoreObject.GetComponent<CountText>().AddLargeScore();
        }
        else if (collision.gameObject.tag == "SmallCloudTag" || collision.gameObject.tag == "SmallStarTag")
        {
            scoreObject.GetComponent<CountText>().AddSmallScore();
        }
    }
}
