using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    bool isInTrigger = false;
    public string scenePath;

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger && Input.GetKeyDown("space")) {
            SceneManager.LoadScene(scenePath);
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
