using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerAttack : MonoBehaviour
{
    public GameObject attackArea1;
    public GameObject attackArea2;

    private bool attacking = true;

    // Start is called before the first frame update
    void Start()
    {
        attackArea1 = transform.GetChild(0).gameObject;
        attackArea2 = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        attacking = true;
        attackArea1.SetActive(attacking);
        attackArea2.SetActive(attacking);
    }
}
