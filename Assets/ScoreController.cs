using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/////////////////////////////////////////////////////////////////////////////
// This Script is intended to be implemented on a game controller object
// but it could feasibly go anywhere really.
// Make sure to include a UI Text object in your scene
// Happy days :)
////////////////////////////////////////////////////////////////////////////

public class ScoreController : MonoBehaviour
{

    public float score = 100.00f;
    public float scoreDecreasePerFrame = 0.1f;
    public playerBalance pB;
    public Text displayScore;
    public Text loseMessage;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(score.ToString().GetType());
        displayScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pB.currentBalance);
        if(pB.currentBalance <= pB.maxLeftLean + 1 || pB.currentBalance >= pB.maxRightLean -1)
        {
            score -= scoreDecreasePerFrame;
        }
           //score-=1;
        displayScore.text = score.ToString();
            

        if(score <= 0.0f)
        {
            loseMessage.verticalOverflow = VerticalWrapMode.Overflow;
            // displayScore.fontSize = 50;
            // displayScore.rectTransform.position = new Vector3(0,94,0);
            
            // displayScore.color = Color.red;
            
            // displayScore.text = "SCRAP METAL...";
        }
        
    }
}
