using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ButtonScript : MonoBehaviour {
    public string next;

    public float transSecond;

    [Header("On:白  Off:黒 でシーン遷移")]public bool iswhite = true;

    public AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        audiosource.Play();
        FadeManager.Instance.LoadScene(next,transSecond,iswhite);
    }
}
