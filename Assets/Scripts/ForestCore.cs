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
    }

    private void Update()
    {
        if (timer.count <= 0)
        {
            MeiyoBeam.SetActive(true);
            animator.SetTrigger("MeiyoBeam");
        }
    }
}
