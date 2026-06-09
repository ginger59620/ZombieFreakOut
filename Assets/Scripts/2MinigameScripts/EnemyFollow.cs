using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;
        currentPos.z = -0.2f; 
        transform.position = currentPos;

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
 
}
