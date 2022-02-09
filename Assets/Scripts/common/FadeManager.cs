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
    /// ��ʑJ�� .
    /// </summary>
    /// <param name='scene'>�V�[����</param>
    /// <param name='interval'>�Ó]�ɂ����鎞��(�b)</param>
    public void LoadScene(string scene, float interval)
    {
        StartCoroutine(TransScene(scene, interval));
    }

    /// <summary>
    /// �V�[���J�ڗp�R���[�`�� .
    /// </summary>
    /// <param name='scene'>�V�[����</param>
    /// <param name='interval'>�Ó]�ɂ����鎞��(�b)</param>
    private IEnumerator TransScene(string scene, float interval)
    {
        //���񂾂�Â� .
        float time = 0;
        while (time <= interval)
        {
            sprite.color = new Color(0f, 0f, 0f, time / interval);
            time += Time.deltaTime;
            yield return null;
        }
        sprite.color = new Color(0f, 0f, 0f, 1f);

        //�V�[���ؑ� .
        SceneManager.LoadScene(scene);
        
        //���񂾂񖾂邭 .
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
