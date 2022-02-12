using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;

    public Animator animator;

    public GameObject Effect;

    public int hp;

    public int atk;

    int count = 0;

    void Awake()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        float x = rigidbody2d.velocity.x;
        float y = rigidbody2d.velocity.y;
        animator.SetFloat("VecX", x);
        animator.SetFloat("VecY", y);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        /*
        if (collisionInfo.gameObject.tag == "PlayerUnit")
        {
            Debug.Log("!");
            damage(collisionInfo.gameObject.GetComponent<Unit>().Atk);
        }
        */
        if(collisionInfo.gameObject.tag == "Core")
        {
            rigidbody2d.velocity = Vector2.zero;
            animator.SetTrigger("Explosion");
            Instantiate(Effect, transform.position, Quaternion.identity);
            
            Destroy(gameObject, 1.0f);
        }
    }

    public void damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
