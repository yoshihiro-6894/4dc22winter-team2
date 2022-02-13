using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit1 : Unit
{
    private float time = 0;

    private bool atk = false;

    protected override void Update()
    {
        base.Update();
        time += Time.deltaTime;
        if (atk)
        {
            //UŒ‚
            if (time >= 1f)
            {
                atk = false;
                animator.SetBool("isAttack", atk);
                time = 0;
            }
        }
        else
        {
            //Idle
            if (time >= AttackInterval)
            {
                atk = true;
                animator.SetBool("isAttack", atk);
                time = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!atk) return;
        
        if (collision.gameObject.tag == "EnemyUnit")
        {
            Debug.Log("!");
            collision.gameObject.GetComponent<CheckGameOver>().damage(this.Atk);
        }
    }

}
