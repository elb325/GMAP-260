using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picture_trigger : item_trigger
{
    // Start is called before the first frame update
    void Start()
    {
        dim_overlay = GameObject.Find("dim_overlay");
        image = GameObject.Find("picture_image");
        textbox = GameObject.Find("picture_textbox");
    }
}
