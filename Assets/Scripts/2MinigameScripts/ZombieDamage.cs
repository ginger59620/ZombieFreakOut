using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;

    private void OnTriggerEnter2D(Collider2D collider)
    {
      if(collider.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }


}
