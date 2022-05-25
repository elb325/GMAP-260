using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    private SpriteRenderer PlayerSprite;

    // Start is called before the first frame update
    void Start()
    {
        PlayerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 5.0f * horizontal * Time.deltaTime;
        position.y = position.y + 5.0f * vertical * Time.deltaTime;
        transform.position = position;
	  if(Input.GetKeyDown("right"))
	  {
            PlayerSprite.flipX=false;
        }
	  if(Input.GetKeyDown("left"))
	  {
            PlayerSprite.flipX=true;
        }

        if (Input.GetKeyDown("escape")) {
            Application.Quit();
        }
	  
    }
}
