using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/HammerManager", order = 1)]
public class HammerManager : ScriptableObject
{

    public bool hasHammer = false;

    // Start is called before the first frame update
    public void obtainHammer()
    {
	  hasHammer = true;
    }

    public bool playerHasHammer() {
        return hasHammer;
    }
}
