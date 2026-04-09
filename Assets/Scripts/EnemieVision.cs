using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieVision : MonoBehaviour
{
    public float minTurnTime = 2f;
    public float maxTurnTime = 5f;

    public BoxCollider2D damageTrigger; // Assign in Inspector
    public float triggerDuration = 0.5f; // How long collider stays active

    private float timer;
    private float nextTurnTime;

    void Start()
    {
        SetNextTurnTime();

        if (damageTrigger != null)
        {
            damageTrigger.enabled = false; // Start disabled
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextTurnTime)
        {
            TurnAround();
            SetNextTurnTime();
        }
    }

    void SetNextTurnTime()
    {
        timer = 0f;
        nextTurnTime = Random.Range(minTurnTime, maxTurnTime);
    }

    void TurnAround()
    {
        transform.Rotate(0, 180, 0);

        // Activate trigger when turning
        if (damageTrigger != null)
        {
            StartCoroutine(ActivateDamageTrigger());
        }
    }

    System.Collections.IEnumerator ActivateDamageTrigger()
    {
        damageTrigger.enabled = true;
        yield return new WaitForSeconds(triggerDuration);
        damageTrigger.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth player = other.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }
        }
    }
}

