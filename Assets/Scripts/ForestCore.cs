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
        HpUItext.text = Hp.ToString();
    }

    public void OnDamage(int damage)
    {
        Hp -= damage;
        HpUItext.text = Hp.ToString();
    }
}
