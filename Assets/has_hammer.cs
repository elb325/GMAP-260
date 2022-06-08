using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class has_hammer : MonoBehaviour
{

    public bool hasHammer;

    // Start is called before the first frame update
    void Start()
    {
        hasHammer = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void obtainHammer()
    {
	  hasHammer = true;
    }
}
