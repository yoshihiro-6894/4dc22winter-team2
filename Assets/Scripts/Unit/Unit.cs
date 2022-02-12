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

    public Animator animator;

    public CircleCollider2D circleCollider2d;

    protected virtual void Update()
    {
        DurationTime -= Time.deltaTime;

        if (0 >= DurationTime)
        {
            Destroy(this.gameObject);
        }
    }
}
