using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouching : MonoBehaviour
{
   /* public Sprite[] standing;
    public Sprite[] croutching;
    private CapsuleCollider2D collide2D;
    private Transform skin;
    private SpriteRenderer characrerRenderer;

    // Start is called before the first frame update
    void Start()
    {
        collide2D = GetComponent<CapsuleCollider2D>();
        characrerRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
       if(Input.GetKey(KeyCode.C))
       {
            Crouch(true);
       }
       else
       {
            Crouch(false);
       }
    }

    public void Crouch(bool pressed)
    {
        if(pressed)
        {
            collide2D.size = new Vector2(collide2D.size.x, 4.5f);
            collide2D.offset = new Vector2(collide2D.offset.x, -0.5f);
            characrerRenderer.sprite = croutching[0];
        }
        else
        {
            collide2D.size = new Vector2 (collide2D.size.x, 6f);
            collide2D.offset = new Vector2 (collide2D.offset.x, 0f);
            characrerRenderer.sprite = standing[0];
        }
    }

    public bool isCrouching()
    {
        return false;
    }*/
}
