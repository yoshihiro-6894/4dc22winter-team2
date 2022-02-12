using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;

    public Animator animator;

    public GameObject Effect;

    public CostManager costmaanger;

    public ForestCore forestcore;
    public int hp;

    public int atk;

    int count = 0;

    public float reward = 10;

    void Awake()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {
        costmaanger = FindObjectOfType<CostManager>();
        forestcore = FindObjectOfType<ForestCore>();
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
            forestcore.OnDamage(atk);
            Destroy(gameObject, 1.0f);
        }
    }

    public void damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            costmaanger.AddPoint(reward);
            Debug.Log("•ñV‚ð‰Á‚¦‚Ü‚µ‚½I");
            rigidbody2d.velocity = Vector2.zero;
            

            Destroy(this.gameObject,1.0f);
        }
    }
}
