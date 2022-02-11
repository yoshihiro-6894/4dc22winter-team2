using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
 //カウントアップ
    public float count = 10.0f;
 
    //タイムリミット
    public float timeLimit = 0.0f;
 
    //時間を表示するText型の変数
    public Text timeText;
 
    // Update is called once per frame
    void Update()
    {
        //時間をカウントする
        count -= Time.deltaTime;
 
        //時間を表示する
        timeText.text = count.ToString("f2");


        if (count <= 10.0f)
        {
            timeText.color = new Color(240, 0, 0);
        }
 
        if(count <= timeLimit)
        {
            timeText.text = 0.ToString("f2");
        }
    }
}
