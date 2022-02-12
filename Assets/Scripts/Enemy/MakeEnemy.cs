using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemy : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;

    [SerializeField] private Vector2 StartPosition;

    [SerializeField] private Vector2 MoveDirection;

    [Header("ê∂ê¨ä‘äu"),SerializeField] private float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MakeEnemys());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MakeEnemys()
    {
        while(true)
        {
            yield return new WaitForSeconds(timer);

            Rigidbody2D r = Instantiate(Enemy, StartPosition, Quaternion.identity).GetComponent<Rigidbody2D>();

            r.velocity = MoveDirection;
        }
    }
}
