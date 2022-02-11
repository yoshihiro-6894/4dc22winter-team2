using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ButtonScript : MonoBehaviour {
    public string next;

    public float transSecond;

    public bool iswhite = true;
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        FadeManager.Instance.LoadScene(next,transSecond,iswhite);
    }
}
