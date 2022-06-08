using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitManor : MonoBehaviour
{
    bool isInTrigger = false;
    public GameObject dim_overlay;
    public GameObject image1;
    public GameObject image2;
    public GameObject textbox1;
    public GameObject textbox2;
    public GameObject textbox3;
    public GameObject use_hammer_button;
    public GameObject leave_door_button;
    public GameObject leave_manor_button;
    public GameObject dont_leave_manor_button;
    public GameObject hasHammer;
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
    void loadState1()
    {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<PlayerMovementScript>().canMove = !player.GetComponent<PlayerMovementScript>().canMove;
		dim_overlay.GetComponent<Image>().enabled = !dim_overlay.GetComponent<Image>().enabled;
		//if (hasHammer.has() == false){
            	image1.GetComponent<Image>().enabled = true;
        		image2.GetComponent<Image>().enabled = false;
        		textbox1.GetComponent<Image>().enabled = true;
        		textbox2.GetComponent<Image>().enabled = false;
			textbox3.GetComponent<Image>().enabled = false;
			use_hammer_button.SetActive(false);
            	leave_door_button.SetActive(false);
    			leave_manor_button.SetActive(false);
    			dont_leave_manor_button.SetActive(false);
		//}
		//else {
		//	image1.GetComponent<Image>().enabled = true;
        	//	image2.GetComponent<Image>().enabled = false;
        	//	textbox1.GetComponent<Image>().enabled = false;
        	//	textbox2.GetComponent<Image>().enabled = true;
		//	textbox3.GetComponent<Image>().enabled = false;
		//	use_hammer_button.SetActive(true);
            //	leave_door_button.SetActive(true);
    		//	leave_manor_button.SetActive(false);
    		//	dont_leave_manor_button.SetActive(false);	
		//	state = 1;
        if (isInTrigger && Input.GetKeyDown("escape")) {
			loadBlankState();
}
        	//}
    }

void loadState2(){
	GameObject player = GameObject.FindGameObjectWithTag("Player");
      player.GetComponent<PlayerMovementScript>().canMove = !player.GetComponent<PlayerMovementScript>().canMove;
	dim_overlay.GetComponent<Image>().enabled = !dim_overlay.GetComponent<Image>().enabled;
      image1.GetComponent<Image>().enabled = false;
      image2.GetComponent<Image>().enabled = true;
      textbox1.GetComponent<Image>().enabled = false;
      textbox2.GetComponent<Image>().enabled = false;
	textbox3.GetComponent<Image>().enabled = true;
	use_hammer_button.SetActive(false);
      leave_door_button.SetActive(false);
    	leave_manor_button.SetActive(true);
    	dont_leave_manor_button.SetActive(true);
	state = 2;
}

void loadBlankState() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlayerMovementScript>().canMove = false;
	  dim_overlay.GetComponent<Image>().enabled = true;
	  image1.GetComponent<Image>().enabled = false;
        image2.GetComponent<Image>().enabled = false;
        textbox1.GetComponent<Image>().enabled = false;
        textbox2.GetComponent<Image>().enabled = false;
	  textbox3.GetComponent<Image>().enabled = false;
	  use_hammer_button.SetActive(false);
        leave_door_button.SetActive(false);
    	  leave_manor_button.SetActive(false);
    	  dont_leave_manor_button.SetActive(false);
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
        loadState2();
    }

    public void noClicked() {
        loadBlankState();
    }
    public void leaveClicked() {
        SceneManager.LoadScene(4);
    }
}