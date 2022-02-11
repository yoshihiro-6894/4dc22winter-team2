using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    //音声用
    public AudioClip ExplosionSE;
    AudioSource audioSource;


    public float ExplosionCount = 5.0f;
    public float ExplosionDestroy = 0.0f;

    void Start () {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(ExplosionSE);
    }

    void Update () {
        // 破壊用
        ExplosionCount -= Time.deltaTime;
        if(ExplosionCount <= ExplosionDestroy)
        {
            Destroy(this.gameObject);
        }
    }
}
