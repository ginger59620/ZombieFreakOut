using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerAttack : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = true;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}
