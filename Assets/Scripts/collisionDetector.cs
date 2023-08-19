using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(enemyAnimationControlling.isdead)
        {
            return;
        }
        print(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            print("hitted player");
            collision.gameObject.GetComponent<playerDamageHndler>().takeDamage(20);
        }
    }
}
