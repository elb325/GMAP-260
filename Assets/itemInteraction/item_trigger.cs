using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class item_trigger : MonoBehaviour
{
    bool isInTrigger = false;
    public GameObject dim_overlay;
    public GameObject image;
    public GameObject textbox;

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger && Input.GetKeyDown("space")) {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<PlayerMovementScript>().canMove = !player.GetComponent<PlayerMovementScript>().canMove;
            dim_overlay.GetComponent<Image>().enabled = !dim_overlay.GetComponent<Image>().enabled;
            image.GetComponent<Image>().enabled = !image.GetComponent<Image>().enabled;
            textbox.GetComponent<Image>().enabled = !textbox.GetComponent<Image>().enabled;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            isInTrigger = true;
            GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            isInTrigger = false;
            GetComponent<Renderer>().enabled = false;
        }
    }
}