using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    public Image sprite;

    public static FadeManager Instance = null;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


    /// <summary>
    /// シーン遷移させる関数
    /// </summary>
    /// <param name="scene">遷移先のシーン名</param>
    /// <param name="interval">暗転の秒数</param>
    public void LoadScene(string scene, float interval)
    {
        StartCoroutine(TransScene(scene, interval));
    }

    /// <summary>
    /// シーン遷移用のコルーチン
    /// </summary>
    /// <param name="scene">シーン名</param>
    /// <param name="interval">暗転の秒数</param>
    /// <returns></returns>
    private IEnumerator TransScene(string scene, float interval)
    {
        //だんだん暗く .
        float time = 0;
        while (time <= interval)
        {
            sprite.color = new Color(0f, 0f, 0f, time / interval);
            time += Time.deltaTime;
            yield return null;
        }
        sprite.color = new Color(0f, 0f, 0f, 1f);

        //シーン切替 .
        SceneManager.LoadScene(scene);
        
        //だんだん明るく .
        time = 0;
        while (time <= interval)
        {
            sprite.color = new Color(0f, 0f, 0f, 1 - time / interval);
            time += Time.deltaTime;
            yield return null;
        }
        sprite.color = new Color(0f, 0f, 0f, 0f);
    }
}
