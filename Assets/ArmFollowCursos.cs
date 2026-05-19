using System;
using UnityEngine;
using UnityEngine.Rendering;
public class ArmFollowCursor : MonoBehaviour
{
    [Header("Character")]
    public Transform character;
    public SpriteRenderer sprite;
    public SpriteRenderer armSprite;

    [Header("Right Side Angles")]
    public float maxAngle = 10f;
    public float minAngle = -10f;

    [Header("Left Side Angles")]
    public float leftMaxAngle = 10f;
    public float leftMinAngle = -10f;
    
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 direction = mousePos - transform.position;
        direction.z = 0f;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (mousePos.x < character.position.x)
        {
            sprite.flipX = true;
            armSprite.flipX = true;

            // angle = Mathf.Clamp(angle, minAngle, maxAngle);
        }
        else
        {
            sprite.flipX = false;
            armSprite.flipX = false;

            // angle = Mathf.Clamp(angle, leftMinAngle, leftMaxAngle);
        }

        // Calcula a direção
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
