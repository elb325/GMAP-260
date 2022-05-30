using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public bool canMove;
    private SpriteRenderer PlayerSprite;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        PlayerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector2 position = transform.position;
            position.x = position.x + 5.0f * horizontal * Time.deltaTime;
            position.y = position.y + 5.0f * vertical * Time.deltaTime;
            transform.position = position;
            if(Input.GetKeyDown("right") || Input.GetKeyDown("d"))
            {
                PlayerSprite.flipX=false;
            }
            if(Input.GetKeyDown("left") || Input.GetKeyDown("a"))
            {
                PlayerSprite.flipX=true;
            }
        }
        if (Input.GetKeyDown("g")) {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation ^ rb.constraints;
        }
        if (Input.GetKeyDown("escape")) {
            Application.Quit();
        }
    }
}
