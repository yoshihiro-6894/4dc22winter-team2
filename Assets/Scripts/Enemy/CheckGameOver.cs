using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.name == "HitEnemyForestGirl")
        {
            Debug.Log("GAMEOVER");
            FadeManager.Instance.LoadScene("GameOver", 1.0f, true);
        }
    }
}
