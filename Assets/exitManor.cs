using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitManor : MonoBehaviour
{
    bool isInTrigger = false;
    public GameObject dim_overlay;
    public GameObject blocked_image;
    public GameObject unblocked_image;
    public GameObject txt_blocked_no_hammer;
    public GameObject txt_blocked_w_hammer;
    public GameObject txt_unblocked;
    public GameObject use_hammer_button;
    public GameObject leave_door_button;
    public GameObject leave_manor_button;
    public GameObject dont_leave_manor_button;
    public HammerManager gm;
    bool isBlocked = true;
    bool isSceneActive = false;

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger && Input.GetKeyDown("space")) {
            if (isSceneActive) {
                loadBlankState();
            } else if (isBlocked && gm.playerHasHammer()) {
                loadBlockedWithHammer();
            } else if (isBlocked) {
                loadBlockedNoHammer();
            } else {
                loadUnblocked();
            }
        }
    }

    void loadScene()
    {   
        isSceneActive = true;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerMovementScript>().canMove = false;
        dim_overlay.GetComponent<Image>().enabled = true;
    }

    void loadBlockedNoHammer()
    {
        loadScene();
        blocked_image.GetComponent<Image>().enabled = true;
        unblocked_image.GetComponent<Image>().enabled = false;
        txt_blocked_no_hammer.GetComponent<Image>().enabled = true;
        txt_blocked_w_hammer.GetComponent<Image>().enabled = false;
        txt_unblocked.GetComponent<Image>().enabled = false;
        use_hammer_button.SetActive(false);
        leave_door_button.SetActive(false);
        leave_manor_button.SetActive(false);
        dont_leave_manor_button.SetActive(false);
    }

    void loadBlockedWithHammer()
    {
        loadScene();
        blocked_image.GetComponent<Image>().enabled = true;
        unblocked_image.GetComponent<Image>().enabled = false;
        txt_blocked_no_hammer.GetComponent<Image>().enabled = false;
        txt_blocked_w_hammer.GetComponent<Image>().enabled = true;
        txt_unblocked.GetComponent<Image>().enabled = false;
        use_hammer_button.SetActive(true);
        leave_door_button.SetActive(true);
        leave_manor_button.SetActive(false);
        dont_leave_manor_button.SetActive(false);
    }

    void loadUnblocked()
    {
        loadScene();
        blocked_image.GetComponent<Image>().enabled = false;
        unblocked_image.GetComponent<Image>().enabled = true;
        txt_blocked_no_hammer.GetComponent<Image>().enabled = false;
        txt_blocked_w_hammer.GetComponent<Image>().enabled = false;
        txt_unblocked.GetComponent<Image>().enabled = true;
        use_hammer_button.SetActive(false);
        leave_door_button.SetActive(false);
        leave_manor_button.SetActive(true);
        dont_leave_manor_button.SetActive(true);
    }

    void loadBlankState()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerMovementScript>().canMove = true;
        dim_overlay.GetComponent<Image>().enabled = false;
        blocked_image.GetComponent<Image>().enabled = false;
        unblocked_image.GetComponent<Image>().enabled = false;
        txt_blocked_no_hammer.GetComponent<Image>().enabled = false;
        txt_blocked_w_hammer.GetComponent<Image>().enabled = false;
        txt_unblocked.GetComponent<Image>().enabled = false;
        use_hammer_button.SetActive(false);
        leave_door_button.SetActive(false);
        leave_manor_button.SetActive(false);
        dont_leave_manor_button.SetActive(false);
        isSceneActive = false;
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

    public void use_hammer_clicked()
    {
        loadUnblocked();
        isBlocked = false;
    }

    public void leave_door_clicked()
    {
        loadBlankState();
    }

    public void leave_manor_clicked() 
    {
        SceneManager.LoadScene("zend");
    }

    public void dont_leave_manor_clicked() 
    {
        loadBlankState();
    }
}