using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieVision : MonoBehaviour
{
    public float minTurnTime = 2f;
    public float maxTurnTime = 5f;

    public Sprite lookingForward;
    public Sprite lookingBack;
    public Sprite warningSprite;
    private SpriteRenderer characrerRenderer;

    public int damage = 1;
    public PlayerHealth playerHealth;

    public BoxCollider2D damageTrigger; // Assign in Inspector
    public float triggerDuration = 5f; // How long collider stays active

    //Delay before turning
    public float warningDuration = 1f;

    private float timer;
    private float nextTurnTime;

    private bool isFacingForward = true;
    private bool isTurning = false;

    void Start()
    {
        SetNextTurnTime();

        if (damageTrigger != null)
        {
            damageTrigger.enabled = false; // Start disabled
        }

        characrerRenderer = GetComponent<SpriteRenderer>();

        //Initial Sprite
        characrerRenderer.sprite = lookingForward;
    }

    void Update()
    {
        if (isTurning)
            return;

        timer += Time.deltaTime;

        if (timer >= nextTurnTime)
        {
            //TurnAround();
            StartCoroutine(TurnSequence());
            SetNextTurnTime();
        }
    }

    void SetNextTurnTime()
    {
        timer = 0f;
        nextTurnTime = Random.Range(minTurnTime, maxTurnTime);
    }
    IEnumerator TurnSequence()
    {
        isTurning = true;

        // Show warning sprite before turning
        characrerRenderer.sprite = warningSprite;

        yield return new WaitForSeconds(warningDuration);

        TurnAround();

        isTurning = false;
    }

    void TurnAround()
    {
        transform.Rotate(0, 180, 0);

        //change sprite depending on direction
        isFacingForward = !isFacingForward;

        if(isFacingForward)
        {
            characrerRenderer.sprite = lookingForward;

            // Disable collider when facing forward
            if (damageTrigger != null)
            {
                damageTrigger.enabled = false;
            }
        }
        else
        {
            characrerRenderer.sprite = lookingBack;

            // Enable collider ONLY when looking back
            if (damageTrigger != null)
            {
                damageTrigger.enabled = true;
            }
        }


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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            Crouching crouching = collision.GetComponent<Crouching>();

            if (playerMovement.isHidden == false)
            {
                /*
                if (!Input.GetKey(KeyCode.C))
                {
                    playerHealth.TakeDamage(1);
                }
                */

                playerHealth.TakeDamage(1);

            }
        }
    }
}

