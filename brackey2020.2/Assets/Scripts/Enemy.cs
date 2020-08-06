using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public GameObject ene;
    public int maxHealth = 100;
    int currentHealth;
    bool isDead = false;
    float timeDis = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //rb = GetComponent<Rigidbody>();
        //rb.mass = mass;
    }


    void Update()
    {

    }
    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");

        if(currentHealth<=0)
        {
            Die();
        }
    }
    void Die()
    {
        animator.SetBool("IsDead", true);
        GetComponent<Collider2D>().enabled = false;
        //rb.mass = 0;
        //ene.SetActive(false);
        this.enabled = false;
    }

}
