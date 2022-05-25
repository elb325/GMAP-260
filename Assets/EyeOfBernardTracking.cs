using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOfBernardTracking : MonoBehaviour
{
     public Transform objectA;
     public Transform Player;
 
     void Start() {
       //Make ObjectA's position match objectB
       objectA.position = new Vector3(Player.position.x + 0.5f, Player.position.y + 2f, 0f);
   
       //Now parent the object so it is always there
       objectA.parent = Player;
     }
}
