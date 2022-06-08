using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onCollisionEnter : MonoBehaviour
{
    void onCollision(Collider2D player){
	  SceneManager.LoadScene(3);
    }
}
