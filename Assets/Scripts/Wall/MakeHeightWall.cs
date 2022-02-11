using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeHeightWall : MonoBehaviour
{
    [SerializeField] private GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {
        for(float i = 2; i < 5; i++)
        {
            Instantiate(Wall, new Vector3(-2, i, 0), Quaternion.identity);
            Instantiate(Wall, new Vector3(2, i, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
