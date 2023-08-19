using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerDamageHndler : MonoBehaviour
{
    public int PlayerHealth = 200;
    public Animator animator;
    public Slider playerhealthBar;
    public static bool isdead = false;
    public ParticleSystem particle;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerhealthBar.value = PlayerHealth;
    }
    public void takeDamage(int damage)
    {
        PlayerHealth -= damage;
        if (PlayerHealth <= 0)
        {
            animator.SetTrigger("isDead");
            isdead = true;

        }
        else
        {
            animator.SetTrigger("isDamage");
            particle.Play();
        }
    }
}
