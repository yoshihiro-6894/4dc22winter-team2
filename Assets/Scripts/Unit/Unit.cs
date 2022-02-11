using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [Header("消えるまでの時間")]
    public float DurationTime;

    [Header("召喚コスト")]
    public int Cost;

    [Header("攻撃力")]
    public int Atk;

    [Header("攻撃間隔秒数")]
    public float AttackInterval;

    [Header("クールタイム")]
    public float CoolTime;

    private float time = 0;

    protected virtual void Update()
    {
        time += Time.deltaTime;

        if (time >= DurationTime)
        {
            Destroy(this.gameObject);
        }
    }
}
