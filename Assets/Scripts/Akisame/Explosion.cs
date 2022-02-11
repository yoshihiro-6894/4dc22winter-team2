using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioClip ExplosionSE;
    AudioSource audioSource;

    void Start () {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(ExplosionSE);
    }

    void Update () {

    }
}
