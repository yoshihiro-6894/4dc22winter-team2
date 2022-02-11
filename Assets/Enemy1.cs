using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public int hp;
    public float speed;
    public Route route;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        var v = Vector3.right;
        transform.position += v * speed * Time.deltaTime;
    }
}
