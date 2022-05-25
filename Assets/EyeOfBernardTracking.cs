using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOfBernardTracking : MonoBehaviour
{
     public Transform objectA;
     public Transform Player;
 
     void Start() {
       //Make ObjectA's position match objectB
       objectA.position = Player.position;
   
       //Now parent the object so it is always there
       objectA.parent = Player;
     }
}
