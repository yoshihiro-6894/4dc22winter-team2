using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
 //カウントアップ
    private float countup = 0.0f;
 
    //タイムリミット
    public float timeLimit = 5.0f;
 
    //時間を表示するText型の変数
    public Text timeText;
 
    // Update is called once per frame
    void Update()
    {
        //時間をカウントする
        countup += Time.deltaTime;
 
        //時間を表示する
        timeText.text = countup.ToString("f1") + "秒";
 
        if(countup >= timeLimit)
        {
            timeText.text = "時間になりました！";
        }
    }
}
