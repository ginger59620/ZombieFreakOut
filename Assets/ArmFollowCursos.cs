using System;
using UnityEngine;
using UnityEngine.Rendering;
public class ArmFollowCursor : MonoBehaviour
{
    [Header("Character")]
    public Transform character;
    public SpriteRenderer bodySprite;

    [Header("Arms")]
    public Transform rightArm;
    public Transform leftArm;

    [Header("Sprites")]
    public SpriteRenderer rightArmSprite;
    public SpriteRenderer leftArmSprite;

    [Header("Right Side Limits")]
    public float rightMinAngle = -60f;
    public float rightMaxAngle = 60f;

    [Header("Left Side Limits")]
    public float leftMinAngle = 120f;
    public float leftMaxAngle = 240f;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector2 dir = mousePos - character.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        bool facingLeft = mousePos.x < character.position.x;

        bodySprite.flipX = facingLeft;

        if (facingLeft)
        {
            leftArmSprite.gameObject.SetActive(true);
            rightArmSprite.gameObject.SetActive(false);

            if (angle < 0)
                angle += 360f;

            float finalAngle = Mathf.Clamp(angle, leftMinAngle, leftMaxAngle);

            leftArm.rotation = Quaternion.Euler(0f, 0f, finalAngle);
        }
        else
        {
            rightArmSprite.gameObject.SetActive(true);
            leftArmSprite.gameObject.SetActive(false);

            float finalAngle = Mathf.Clamp(angle, rightMinAngle, rightMaxAngle);

            rightArm.rotation = Quaternion.Euler(0f, 0f, finalAngle);
        }
    }
}
