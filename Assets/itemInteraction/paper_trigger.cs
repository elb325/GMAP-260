using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper_trigger : item_trigger
{
    // Start is called before the first frame update
    void Start()
    {
        dim_overlay = GameObject.Find("dim_overlay");
        image = GameObject.Find("paper_image");
        textbox = GameObject.Find("paper_textbox");
    }
}
