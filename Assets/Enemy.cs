using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public int maxHP = 100;     //HP100�Ƃ��ĂЂƂ܂��ݒ�
    private int hp;
    bool isDeath;
    private bool moveEnabled = true;
    private MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHP;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)     //��_���[�W�Ɋւ��鏈��
    {
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            animator.SetTrigger("Gethit");       //�v���C���[�̌�������������_���[�W�A�j���[�V��������
            Damage(damager.damage);
        }
    }
    // Update is called once per frame
    void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
            animator.SetTrigger("Death");
            Destroy(gameObject, 5f);�@�@�@//�|�ꂽ��ɃV�[��������ł�����
        }
    }
}
