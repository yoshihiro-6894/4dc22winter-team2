using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchEnemy : MonoBehaviour
{
    [SerializeField] private float SearchRange;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit2D[] hit = Physics2D.CircleCastAll(transform.position, SearchRange, Vector2.zero, Mathf.Infinity, 1 << 7);

        foreach(var h in hit)
        {
            //Debug.Log("enemy exist!" + h.collider.name);
        }
    }
}
