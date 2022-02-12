using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject a = GameObject.FindGameObjectWithTag("Core");
        //a.GetComponent<ForestCore>().OnDamage(4);
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
