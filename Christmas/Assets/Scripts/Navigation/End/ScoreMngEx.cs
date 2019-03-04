using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMngEx : MonoBehaviour
{
    public Text PlayerScoreVal;
    public Text TimeVal;
    float PlayerScoreValue;
    public float TimeValue;

    public Camera InGameCam;
    public Camera GameOverCam;

    Collision collision;

    private void Start()
    {
        TimeValue = 30;
        InGameCam.depth = 1;
        GameOverCam.depth = 0;
    }

    void Update()
    {
        TimeValue -= Time.deltaTime;
        if(TimeValue <= 0)
        {
            TimeValue = 0;
            InGameCam.depth = 0;
            GameOverCam.depth = 1;
        }      
        PlayerScoreVal.text = PlayerScoreValue.ToString("0000");
        TimeVal.text = TimeValue.ToString("0000");
    }

   public void AddScore()
   {
        if (TimeValue > 0)
        {
            PlayerScoreValue += 100;
            TimeValue += 15;
        }
   }
}