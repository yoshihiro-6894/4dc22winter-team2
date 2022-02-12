using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit1 : Unit
{
    private float time = 0;

    protected override void Update()
    {
        base.Update();
        time += Time.deltaTime;
        if (time >= AttackInterval)
        {
            animator.SetTrigger("Biting");
            time = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyUnit")
        {
            Debug.Log("!");
            collision.gameObject.GetComponent<CheckGameOver>().damage(this.Atk);
        }
    }

    private void ResetValue()
    {
        //circleCollider2d.enabled = false;
        //time = 0;
    }
}
