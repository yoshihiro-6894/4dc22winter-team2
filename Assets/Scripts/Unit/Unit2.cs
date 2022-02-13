using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit2 : Unit
{
    private float time = 0;

    public GameObject AttackEffect;

    public bool isAttack = false;

    protected override void Update()
    {
        base.Update();
        time += Time.deltaTime;
        if (isAttack)
        {
            //UŒ‚
            if (time >= 1f)
            {
                isAttack = false;
                animator.SetBool("isAttack", isAttack);
                AttackEffect.SetActive(isAttack);
                time = 0;
            }
        }
        else
        {
            //Idle
            if (time >= AttackInterval)
            {
                isAttack = true;
                animator.SetBool("isAttack", isAttack);
                AttackEffect.SetActive(isAttack);
                time = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isAttack) return;

        if (collision.gameObject.tag == "EnemyUnit")
        {
            Debug.Log("!!");
            collision.gameObject.GetComponent<CheckGameOver>().damage(this.Atk);
        }
    }
}
