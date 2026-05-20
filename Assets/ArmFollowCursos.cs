using System;
using UnityEngine;
using UnityEngine.Rendering;
public class ArmFollowCursor : MonoBehaviour
{
    [Header("Character")]
    public Transform character;
    public SpriteRenderer bodySprite;
    public SpriteRenderer armSprite;

    [Header("Right Side Angles")]
    public float rightMinAngle = -45f;
    public float rightMaxAngle = 45f;

    [Header("Left Side Angles")]
    public float leftMinAngle = -45f;
    public float leftMaxAngle = 45f;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        // Direction from character (NOT arm transform)
        Vector2 dir = mousePos - character.position;

        float rawAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        bool facingLeft = dir.x < 0f;

        // Flip visuals based on mouse position
        bodySprite.flipX = facingLeft;
        armSprite.flipX = facingLeft;

        float clampedAngle;

        if (facingLeft)
        {
            // Convert angle to left-side reference (-180..180 normalization helps stability)
            clampedAngle = Mathf.Clamp(rawAngle, leftMinAngle, leftMaxAngle);
        }
        else
        {
            clampedAngle = Mathf.Clamp(rawAngle, rightMinAngle, rightMaxAngle);
        }

        transform.rotation = Quaternion.Euler(0f, 0f, clampedAngle);
    }
}
