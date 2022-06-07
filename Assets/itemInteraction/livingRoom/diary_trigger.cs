using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diary_trigger : MonoBehaviour
{
    bool isInTrigger = false;
    public GameObject dim_overlay;
    public GameObject image1;
    public GameObject image2;
    public GameObject textbox1;
    public GameObject textbox2;
    public GameObject yes_button;
    public GameObject no_button;
    public int state;

    void Start()
    {
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger && Input.GetKeyDown("space")) {
            if (state == 0) {
                loadState1();
            } else {
                loadBlankState();
            }
        }
    }

    void loadState1() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerMovementScript>().canMove = false;
        dim_overlay.GetComponent<Image>().enabled = true;
        image1.GetComponent<Image>().enabled = true;
        image2.GetComponent<Image>().enabled = false;
        textbox1.GetComponent<Image>().enabled = true;
        textbox2.GetComponent<Image>().enabled = false;
        yes_button.SetActive(true);
        no_button.SetActive(true);
        state = 1;
    }

    void loadState2() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerMovementScript>().canMove = false;
        dim_overlay.GetComponent<Image>().enabled = true;
        image1.GetComponent<Image>().enabled = false;
        image2.GetComponent<Image>().enabled = true;
        textbox1.GetComponent<Image>().enabled = false;
        textbox2.GetComponent<Image>().enabled = true;
        yes_button.SetActive(false);
        no_button.SetActive(false);
        state = 2;
    }

    void loadBlankState() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerMovementScript>().canMove = true;
        dim_overlay.GetComponent<Image>().enabled = false;
        image1.GetComponent<Image>().enabled = false;
        image2.GetComponent<Image>().enabled = false;
        textbox1.GetComponent<Image>().enabled = false;
        textbox2.GetComponent<Image>().enabled = false;
        yes_button.SetActive(false);
        no_button.SetActive(false);
        state = 0;
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
        Debug.Log("yes clicked");
        loadState2();
    }

    public void noClicked() {
        Debug.Log("no clicked");
        loadBlankState();
    }
}