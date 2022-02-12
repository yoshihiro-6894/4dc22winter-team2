using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForestCore : MonoBehaviour
{
    public int MaxHp = 500;

    public int Hp;

    public Text HpUItext;

    public Slider HpBar;

    public Timer timer;

    public GameObject MeiyoBeam;

    public Animator animator;

    public bool Finished = false;

    private void Start()
    {
        Hp = MaxHp;
        HpUItext.text = "HP  " + Hp.ToString("d3") + "/" + MaxHp.ToString();
        HpBar.value = 100.0f * Hp / MaxHp;
    }

    /// <summary>
    /// 森のコアにダメージを与える関数
    /// </summary>
    /// <param name="damage">ダメージ量(正の自然数)</param>
    public void OnDamage(int damage)
    {
        Hp -= damage;
        HpUItext.text = "HP  "+Hp.ToString("d3") + "/" + MaxHp.ToString();
        HpBar.value = 100.0f * Hp / MaxHp;

        if (Hp <= 0 && !Finished)
        {
            Finished = true;
            FadeManager.Instance.LoadScene("GameOver", 1f, false);
        }
    }

    private void Update()
    {
        if (timer.count <= 0 && !Finished)
        {
            Finished = true;
            MeiyoBeam.SetActive(true);
            animator.SetTrigger("MeiyoBeam");

            FadeManager.Instance.LoadScene("GameClear", 3f, true);
        }
    }
}
