using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backGroundMove : MonoBehaviour
{
    Vector3 startPos;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1*speed*Time.deltaTime, speed*Time.deltaTime, 0);

        if (transform.position.x <= 0.98 && transform.position.y >= 4.9)
        {
            transform.position = startPos;
        }
    }
}
