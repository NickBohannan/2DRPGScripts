using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Vector2 lastPosition;

    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Sprite startingSprite;

    Vector2 movement;

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator.enabled);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (rb.position.x == lastPosition.x && rb.position.y == lastPosition.y)
        {
            animator.enabled = false;
            spriteRenderer.sprite = startingSprite;
        }
        else
        {
            animator.enabled = true;
        }

        lastPosition.x = rb.position.x;
        lastPosition.y = rb.position.y;
    }

    /*private void toggleWalkAnimation()
    {
        if ()
    }
    */
}
