using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (enemyAnimationControlling.isdead)
        {
            return;
        }
        print(collision.gameObject.name);
        if (collision.gameObject.CompareTag("enemy"))
        {
            print("hitted enemy");
            collision.gameObject.GetComponent<damageforenemy>().TakeDamage(20);
        }
    }
   
}
