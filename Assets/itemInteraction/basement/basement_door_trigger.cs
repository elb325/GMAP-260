using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basement_door_trigger : MonoBehaviour
{
    bool isInTrigger = false;
    public GameObject dim_overlay;
    public GameObject image;
    public GameObject textbox;
    public Button yes_button;
    public Button no_button;

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger && Input.GetKeyDown("space")) {
            changeState();
        }
    }

    void changeState() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerMovementScript>().canMove = !player.GetComponent<PlayerMovementScript>().canMove;
        dim_overlay.GetComponent<Image>().enabled = !dim_overlay.GetComponent<Image>().enabled;
        image.GetComponent<Image>().enabled = !image.GetComponent<Image>().enabled;
        textbox.GetComponent<Image>().enabled = !textbox.GetComponent<Image>().enabled;
        yes_button.interactable = !yes_button.interactable;
        no_button.interactable = !no_button.interactable;
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

    public void yesClicked() {
        SceneManager.LoadScene(2);
    }

    public void noClicked() {
        changeState();
    }
}