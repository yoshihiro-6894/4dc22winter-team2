using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForestCore : MonoBehaviour
{
    public int MaxHp = 500;

    public int Hp;

    public Text HpUItext;

    private void Start()
    {
        Hp = MaxHp;
        HpUItext.text = Hp.ToString() + "/" + MaxHp.ToString();
    }

    /// <summary>
    /// 森のコアにダメージを与える関数
    /// </summary>
    /// <param name="damage">ダメージ量(正の自然数)</param>
    public void OnDamage(int damage)
    {
        Hp -= damage;
        HpUItext.text = Hp.ToString() + "/" + MaxHp.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnDamage(5);
        }
    }
}
